using System;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanDatabase.DataClasses.Product;
using ElbayanServices.Repository.Clints.Orders.Dtos;

namespace ElbayanServices.Repository.Clints.Orders
{
    public class OrderService : IOrder, IDisposable
    {
        private readonly ConnectionOption _context;

        public OrderService(ConnectionOption context)
        {
            _context = context;
        }
        public ProductPriceMovementDto GetProductPriceMovement(Guid productId)
        {
            var product = _context.Products.FirstOrDefault(d => d.Id == productId);

            if (product != null)
            {
                return new ProductPriceMovementDto()
                {
                    ProductDefaultSale = product.SaleDefaultPrice,
                    ProductDiscount = product.Discount,
                    ProductVat = product.Vat
                };
            }

            return null;
        }

        public decimal GetLastProductPrice(Guid productId)
        {
            var product = _context.ProductPrices.OrderByDescending(d=>d.DateTime).FirstOrDefault(d => d.Id == productId);
            if (product!=null)
            {
                return product.ProcPrice;
            }

            return 0;
        }

        public bool CreateCustomerOrder(OrderDto model)
        {

            var order = _context.Orders.Add(new Order
            {
                EmployeeId = model.EmployeeId,
                IsDeferred = model.IsDeferred,
                Deferred = model.Deferred,
                DateTime =DateTime.UtcNow,
                Payment = model.Payment,
                IsReturn = false,
                OrderNumber = GenerateSequenceNumberSupplier(),
                OrderType = "مبيعات",
                ClintId = model.ClintId,
                TotalDiscount = model.TotalDiscount,
                SubTotalWithoutDiscount = model.SubTotalWithoutDiscount,
                TotalAfterDiscount = model.TotalAfterDiscount,
                PosId = model.PosId
            });
            _context.SaveChanges();
            if (order.IsDeferred)
            {
                CreateDeferredPayments(model.ClintId, order.Deferred, order.Id, model.DueDatePayingOff,model.PaymentPerMonth);
            }

            if (order != null)
            {
                foreach (var orderProduct in model.OrderProductDto)
                {
                    var productPriceOnce = orderProduct.PriceSale / orderProduct.Quantity;
                    //اضافة كميه جديد الي المنتج
                    CreateProductOrder(orderProduct, order.Id);
                    //اضافة الكميه الي المنتج في جدول المنتجات 
                    OrderProductQuantity(orderProduct.ProductId, orderProduct.Quantity);
                    //اضافة الكميه الجديده الي جدول حركة المنتج 
                    OrderProductStock(orderProduct.ProductId, orderProduct.Quantity, order.Id);

                    OrderProductPrice(orderProduct.ProductId, productPriceOnce, orderProduct.Discount, orderProduct.Vat);
                    _context.SaveChanges();
                }
              
            }
            return true;
        }
        private void OrderProductPrice(Guid productId, decimal price, decimal discount, int vat)
        {
            var product = _context.ProductPrices.Add(new ProductPrice()
            {
                ProductId = productId,
                DateTime = DateTime.UtcNow,
                Discount = discount,
                Vat = vat,
                ProcPrice = price,
                Id = Guid.NewGuid(),
                ProcessType = "مبيعات"
            });

        }
        private void OrderProductStock(Guid productId, int quantity, Guid orderId)
        {
            var product = _context.ProductStocks.Add(new ProductStock()
            {
                ProductId = productId,
                OrderId = orderId,
                Stock = quantity,
                Id = Guid.NewGuid(),
                DateTime = DateTime.UtcNow,
            });
        }
        private void OrderProductQuantity(Guid productId, int quantity)
        {
            var product = _context.Products.FirstOrDefault(d => d.Id == productId);

            var productQuantity = product.TotalQuantity;
            productQuantity = productQuantity - quantity;
            product.TotalQuantity = productQuantity;
        }

        private void CreateProductOrder(OrderProductDto model,Guid orderId)
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
        private void CreateDeferredPayments(Guid clintId,decimal deferred, Guid orderId, DateTime dueDatePayingOff, decimal paymentPerMonth )
        {
            var payment = _context.DeferredPayments.Add(new DeferredPayment
            {
                Balance = deferred,
                Payment = 0,
                OrderId = orderId,
                DeferredOfOrder = deferred,
                CreatedDate = DateTime.UtcNow,
                DueDatePayingOff = dueDatePayingOff,
                TotalPayment = 0,
                ClintId = clintId,
            });
            _context.SaveChanges();
        }
        //Customer
        private bool ProductStock(Guid productId, int quantity)
        {
            var productStock =
            _context.ProductStocks.FirstOrDefault(d => d.ProductId == productId);
            productStock.Stock -= quantity;
            return true;
        }
        private int ProductQuantity(Guid productId)
        {
            return _context.Products.FirstOrDefault(d => d.Id == productId).TotalQuantity;


        }

        public long GenerateSequenceNumber()
        {
            var lastNumber = _context.Orders.Max().OrderNumber;
            if (lastNumber >= 0)
            {
                return (long) (lastNumber + 1);
            }

            return 0033340;
        }

        public long GenerateSequenceNumberSupplier()
        {
            var lastNumber = _context.Orders.AsEnumerable().Select(d=>d.OrderNumber).LastOrDefault();
            if (lastNumber >= 0)
            {
                return (long)(lastNumber + 1);
            }

            return 201020;
        }
        public void Dispose()
        {
            _context.Dispose();

        }
    }
}
