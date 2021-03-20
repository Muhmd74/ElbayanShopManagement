using System;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanDatabase.DataClasses.Product;
using ElbayanServices.Common;
using ElbayanServices.Repository.Clints.OrderProcurement.Dtos;
//using ElbayanServices.Repository.Clints.Orders.Dtos;

namespace ElbayanServices.Repository.Clints.OrderProcurement
{
    public class OrderProcurementService
    {
        private readonly ConnectionOption _context;

        public OrderProcurementService(ConnectionOption context)
        {
            _context = context;
        }
        public bool CreateSupplierOrder(OrderDto model)
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
                OrderType = "فاتورة مشتريات",
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
                    //اضافة كميه جديد الي المنتج
                    CreateProductOrder(orderProduct, order.Id);
                    //اضافة الكميه الي المنتج في جدول المنتجات 
                    SupplierProductQuantity(orderProduct.ProductId, orderProduct.Quantity);
                    //اضافة الكميه الجديده الي جدول حركة المنتج 
                    //SupplierProductStock(orderProduct.ProductId, orderProduct.Quantity, order.Id);
                    _context.SaveChanges();
                }

            }
            return true;
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
        private void CreateDeferredPayments(Guid clintId, decimal deferred, Guid orderId, DateTime dueDatePayingOff, decimal paymentPerMonth)
        {
            var payment = _context.DeferredPayments.Add(new DeferredPayment
            {
                Balance = deferred,
                Payment = 0,
                OrderId = orderId,
                DeferredOfOrder = deferred,
                CollectingPaymentDate = DateTime.UtcNow,
                DueDatePayingOff = dueDatePayingOff,
                TotalPayment = 0,
                ClintId = clintId,
                PaymentPerMonth = paymentPerMonth
            });
            _context.SaveChanges();
        }
        private void SupplierProductStock(Guid productId, int quantity, Guid orderID)
        {
            //var product = _context.ProductStocks.FirstOrDefault(d => d.ProductId == productId);
            //if (product!=null)
            //{
                var product = _context.ProductStocks.Add(new ProductStock()
                {
                    ProductId = productId,
                    OrderId = orderID,
                    Stock = quantity,
                    StockStatues = StaticGenerator.ProductStockStatues.Procurement
                });
            
            //return true;
            //}
            //else
            //{
            //    _context.ProductStocks.Add(new ProductStock()
            //    {
            //        ProductId = productId,
            //        Stock = quantity,
            //        StockStatues = StaticGenerator.ProductStockStatues.OpeningBalances
            //    }); 
            //}
            //return true;
        }
        private bool SupplierProductQuantity(Guid productId, int quantity)
        {
            var productQuantity = _context.Products.FirstOrDefault(d => d.Id == productId).TotalQuantity;
            productQuantity = productQuantity + quantity;
            _context.Products.FirstOrDefault(d => d.Id == productId).TotalQuantity = productQuantity;
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
    }
}
