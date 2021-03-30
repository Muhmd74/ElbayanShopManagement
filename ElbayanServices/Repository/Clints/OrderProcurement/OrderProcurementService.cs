using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanDatabase.DataClasses.Product;
using ElbayanServices.Repository.Clints.OrderProcurement.Dtos;
//using ElbayanServices.Repository.Clints.Orders.Dtos;

namespace ElbayanServices.Repository.Clints.OrderProcurement
{
    public class OrderProcurementService : IOrderProcurement
    {
        private readonly ConnectionOption _context;

        public OrderProcurementService(ConnectionOption context)
        {
            _context = context;
        }
        public Guid CreateSupplierOrder(OrderDto model)
        {
            var order = _context.Orders.Add(new Order()
            {
                EmployeeId = model.EmployeeId,
                IsDeferred = model.IsDeferred,
                Deferred = model.Deferred,
                DateTime = model.DateTime,
                Payment = model.Payment,
                OrderNumber = model.OrderNumber,
                IsReturn = false,
                OrderType = "مشتريات",
                ClintId = model.ClintId,
                TotalDiscount = model.TotalDiscount,
                SubTotalWithoutDiscount = model.SubTotalWithoutDiscount,
                TotalAfterDiscount = model.TotalAfterDiscount,
                PosId = model.PosId
            });
            _context.SaveChanges();
            if (order.IsDeferred)
            {
                CreateDeferredPayments(model.ClintId, order.Deferred, order.Id, model.DueDatePayingOff, model.PaymentPerMonth);
            }

            if (order != null)
            {
                foreach (var orderProduct in model.OrderProductDto)
                {
                    var productPriceOnce = orderProduct.PriceSale / orderProduct.Quantity;
                    //اضافة كميه جديد الي المنتج
                    CreateProductOrder(orderProduct, order.Id);
                    //اضافة الكميه الي المنتج في جدول المنتجات 
                    SupplierProductQuantity(orderProduct.ProductId, orderProduct.Quantity);
                    //اضافة الكميه الجديده الي جدول حركة المنتج 
                    SupplierProductStock(orderProduct.ProductId, orderProduct.Quantity, order.Id);
                    SupplierProductPrice(orderProduct.ProductId, productPriceOnce, orderProduct.Discount, orderProduct.Vat);
                    _context.SaveChanges();
                }
            }
            return order.Id;
        }
        private void CreateProductOrder(OrderProductDto model, Guid orderId)
        {
            var productOrder = _context.OrderProducts.Add(new OrderProduct()
            {
                Discount = model.Discount,
                Name = model.ProductName,
                OrderId = orderId,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                PriceSale = model.PriceSale,
                SubTotalPrice = model.SubTotalPrice,
                TotalProductPrice = model.TotalProductPrice,
                Vat = model.Vat,
                TotalPrice = model.TotalPrice,

            });
        }
        internal void CreateDeferredPayments(Guid clintId, decimal deferred, Guid orderId, DateTime dueDatePayingOff, decimal paymentPerMonth)
        {
            var payment = _context.DeferredPayments.Add(new DeferredPayment
            {
                Balance = deferred,
                Payment = 0,
                OrderId = orderId,
                DeferredOfOrder = deferred,
                CollectingPaymentDate = DateTime.Now,
                DueDatePayingOff = dueDatePayingOff,
                TotalPayment = 0,
                ClintId = clintId,
                PaymentPerMonth = paymentPerMonth
            });
            _context.SaveChanges();
        }
        private void SupplierProductStock(Guid productId, int quantity, Guid orderId)
        {
            var product = _context.ProductStocks.Add(new ProductStock()
            {
                ProductId = productId,
                OrderId = orderId,
                Stock = quantity,
                Id = Guid.NewGuid(),
                DateTime = DateTime.Now,
            });
        }
        private void SupplierProductPrice(Guid productId, decimal price, decimal discount, decimal vat)
        {
            var product = _context.ProductPrices.Add(new ProductPrice()
            {
                ProductId = productId,
                DateTime = DateTime.Now,
                Discount = discount,
                Vat = vat,
                ProcPrice = price,
                Id = Guid.NewGuid(),
                ProcessType = "مشتريات"
            });

        }
        private bool SupplierProductQuantity(Guid productId, int quantity)
        {
            var product = _context.Products.FirstOrDefault(d => d.Id == productId);

            var productQuantity = product.TotalQuantity;
            productQuantity = productQuantity + quantity;
            product.TotalQuantity = productQuantity;
            _context.SaveChanges();
            return true;

        }
        public long GenerateSequenceNumberSupplier()
        {
            var lastNumber = _context.Orders.AsEnumerable().Select(d => d.OrderNumber).LastOrDefault();
            if (lastNumber >= 0)
            {
                return (long)(lastNumber + 1);
            }

            return 201020;
        }
        public decimal GetLastProductPrice(Guid productId)
        {
            var product = _context.ProductPrices.OrderBy(d => d.DateTime)
                .FirstOrDefault(d => d.ProcessType == "مشتريات" && d.ProductId == productId);
            if (product != null)
            {
                return product.ProcPrice;
            }
            return 0;
        }

        public List<InvoiceDetailsDto> PrintInvoice(Guid orderId)
        {
            var order = _context.Orders
                .Include(d => d.OrderProduct).FirstOrDefault(d => d.Id == orderId);
            var clint = _context.Orders
                .Include(d => d.Clint).FirstOrDefault(d => d.Id == orderId);
            var employee = _context.Orders
                .Include(d => d.Employee).FirstOrDefault(d => d.Id == orderId);
            var pos = _context.Orders
                .Include(d => d.Pos).FirstOrDefault(d => d.Id == orderId);

            var productOrder = _context.OrderProducts
                .Include(d => d.Product.SmallUnit)
                .Include(d => d.Product.LargeUnit)
                .Where(d => d.OrderId == orderId).ToList();
            var firm = _context.Firms.FirstOrDefault();

            if (order != null)
            {
                var inovioce =  new InvoiceDetailsDto()
                {

                    FirmName = firm.Name,
                    LogoInvoice = firm.LogoInvoice,
                    MessageInvoice = firm.MessageInvoice,
                    Mobile = firm.Mobile,
                    Phone = firm.Phone,

                    OrderNumber = order.OrderNumber,
                    DateTime = order.DateTime,
                    OrderType = order.OrderType,
                    TotalAfterDiscount = order.TotalAfterDiscount,
                    DeferredPrice = order.Deferred,
                    Payment = order.Payment,
                    TotalDiscount = order.TotalDiscount,

                    ClintName = clint.Clint.Name,
                    EmployeeName = employee.Employee.Name,
                    PosName = pos.Pos.Name,

                    ProductCount = order.OrderProduct.Count,
                    TotalVat = order.OrderProduct.Sum(d => d.Vat),
                    Products = productOrder.Select(d => new ProductDto
                    {
                        Quantity = d.Quantity,
                        ProductName = d.Name,
                        TotalProductPrice = d.TotalProductPrice,
                        UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,
                        Price = d.PriceSale
                    }).ToList()
                    
                };
                List<InvoiceDetailsDto> invoiceDetails = new List<InvoiceDetailsDto>();
                invoiceDetails.Add(inovioce);
                return invoiceDetails.ToList();
            }
            return null;
        }
    }
}
