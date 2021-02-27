using System;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Customers.Sales;
using ElbayanServices.Repository.Customers.Orders.Dtos;

namespace ElbayanServices.Repository.Customers.Orders
{
    public class OrderService : IOrder, IDisposable
    {
        private readonly ConnectionOption _context;

        public OrderService(ConnectionOption context)
        { 
            _context = context;
        }

        public bool Create(OrderDto model)
        {

            var order = _context.Orders.Add(new Order
            {
                PosId = model.PosId,
                CustomerId = model.CustomerId,
                EmployeeId = model.EmployeeId,
                IsDeferred = model.IsDeferred,
                Deferred = model.Deferred,
                DateTime = model.DateTime,
            });
            _context.SaveChanges();
            if (order.IsDeferred)
            {
                var payment = _context.DeferredPayments.Add(new DeferredPayment()
                {
                    Balance = order.Deferred,
                    Payment = 0,
                    OrderId = order.Id,
                    DeferredOfOrder = order.Deferred,
                    CollectingPaymentDate = DateTime.UtcNow,
                    DueDatePayingOff = model.DueDatePayingOff,
                    TotalPayment = 0
                });
                _context.SaveChanges();
            }

            if (order != null)
            {
                foreach (var orderProduct in model.OrderProductDto)
                {
                    var productOrder = _context.OrderProducts.Add(new OrderProduct()
                    {
                        Discount = orderProduct.Discount,
                        Name = orderProduct.ProductName,
                        OrderId = order.Id,
                        ProductId = orderProduct.ProductId,
                        Quantity = orderProduct.Quantity,
                        PriceSale = orderProduct.PriceSale,
                        SubTotalPrice = orderProduct.SubTotalPrice,
                        TotalProductPrice = orderProduct.TotalProductPrice,
                        Vat =orderProduct.Vat,
                        TotalPrice =orderProduct.TotalPrice
                    });
                }
                _context.SaveChanges();
                var orderTable = _context.Orders.FirstOrDefault(d => d.Id == order.Id);
                orderTable.TotalDiscount = model.TotalDiscount;
                orderTable.SubTotalWithoutDiscount = model.SubTotalWithoutDiscount;
                orderTable.TotalAfterDiscount = model.TotalAfterDiscount;
                _context.SaveChanges();


            }
            return true;
        }

        public ProductPriceMovementDto GetProductPriceMovement(Guid productId)
        {
          var product = _context.Products.FirstOrDefault(d => d.Id == productId);
          return new ProductPriceMovementDto()
          {
              productDefaultSale = product.SaleDefaultPrice,
              productDiscount = product.Discount,
              productVat = product.Vat
          };
        }

        public void Dispose()
        {
            _context.Dispose();

        }
    }
}
