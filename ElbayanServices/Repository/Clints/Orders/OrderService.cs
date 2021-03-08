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
                OrderNumber = GenerateSequenceNumber(),
                IsReturn = false,
                OrderType = "فاتورة مبيعات"

            });
            _context.SaveChanges();
            if (order.IsDeferred)
            {
                CreateDeferredPayments(order.Deferred, order.Id, model.DueDatePayingOff);
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

        public bool CreateCustomerReturnOrder(OrderDto model)
        {
            var order = _context.Orders.Add(new Order()
            {

                EmployeeId = model.EmployeeId,
                IsDeferred = model.IsDeferred,
                Deferred = model.Deferred,
                DateTime = model.DateTime,
                Payment = model.Payment,
                OrderNumber = GenerateSequenceNumberSupplier(),
                IsReturn = true,
                OrderType = "فاتورة مرتجع مبيعات"
            });
            _context.SaveChanges();
            if (order.IsDeferred)
            {
                CreateDeferredPayments(order.Deferred, order.Id, model.DueDatePayingOff);

            }

            if (order != null)
            {
                foreach (var orderProduct in model.OrderProductDto)
                {
                    CreateProductOrder(orderProduct, order.Id);

                    SupplierProductQuantity(orderProduct.ProductId, orderProduct.Quantity);
                    SupplierProductStock(orderProduct.ProductId, orderProduct.Quantity);
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
        public bool CreateSupplierOrder(OrderDto model)
        {
            var order = _context.Orders.Add(new Order()
            {

                EmployeeId = model.EmployeeId,
                IsDeferred = model.IsDeferred,
                Deferred = model.Deferred,
                DateTime = model.DateTime,
                Payment = model.Payment,
                OrderNumber = GenerateSequenceNumberSupplier(),
                IsReturn = false,
                OrderType = "فاتورة مشتريات"
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
                        Vat = orderProduct.Vat,
                        TotalPrice = orderProduct.TotalPrice
                    });
                    SupplierProductQuantity(orderProduct.ProductId, orderProduct.Quantity);
                    SupplierProductStock(orderProduct.ProductId, orderProduct.Quantity);
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
        private void CreateDeferredPayments(decimal deferred, Guid orderId, DateTime dueDatePayingOff)
        {
            var payment = _context.DeferredPayments.Add(new DeferredPayment()
            {
                Balance = deferred,
                Payment = 0,
                OrderId = orderId,
                DeferredOfOrder = deferred,
                CollectingPaymentDate = DateTime.UtcNow,
                DueDatePayingOff = dueDatePayingOff,
                TotalPayment = 0,
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
                return (long)(lastNumber + 1);
            }

            return 0033340;
        }
        //Supplier
        private int SupplierProductQuantity(Guid productId, int quantity)
        {

            var productQuantity = _context.Products.FirstOrDefault(d => d.Id == productId).TotalQuantity;
            productQuantity += quantity;
            return productQuantity;

        }
        private bool SupplierProductStock(Guid productId, int quantity)
        {
            var productStock =
                _context.ProductStocks.FirstOrDefault(d => d.ProductId == productId);
            if (productStock != null)
            {
                productStock.Stock += quantity;
                productStock.StockStatues = StaticGenerator.ProductStockStatues.Procurement;
                return true;
            }

            return false;
        }
        public long GenerateSequenceNumberSupplier()
        {
            var lastNumber = _context.Orders.Max().OrderNumber;
            if (lastNumber >= 0)
            {
                return (long)(lastNumber + 1);
            }

            return 0022250;
        }
        public void Dispose()
        {
            _context.Dispose();

        }
    }
}
