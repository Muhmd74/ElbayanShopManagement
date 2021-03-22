using System;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanServices.Common;
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
                PosId = model.PosId,
                ClintId = model.ClintId,
                EmployeeId = model.EmployeeId,
                IsDeferred = model.IsDeferred,
                Deferred = model.Deferred,
                DateTime = model.DateTime,
                Payment = model.Payment,
                OrderNumber = GenerateSequenceNumberSupplier(),
                IsReturn = false,
                OrderType = "فاتورة مبيعات"

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
                    var orderProductQuantity = ProductQuantity(orderProduct.ProductId);
                    if (orderProductQuantity >= orderProduct.Quantity)
                    {
                        CreateProductOrder(orderProduct, order.Id);
                        orderProductQuantity -= orderProduct.Quantity;
                        ProductStock(orderProduct.ProductId, orderProduct.Quantity);

                    }
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
                CollectingPaymentDate = DateTime.UtcNow,
                DueDatePayingOff = dueDatePayingOff,
                TotalPayment = 0,
                ClintId = clintId,
                PaymentPerMonth = paymentPerMonth
            });
            _context.SaveChanges();
        }
        //Customer
        private bool ProductStock(Guid productId, int quantity)
        {
            var productStock =
            _context.ProductStocks.FirstOrDefault(d => d.ProductId == productId);
            productStock.Stock -= quantity;
            productStock.StockStatues = StaticGenerator.ProductStockStatues.Sale;
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
