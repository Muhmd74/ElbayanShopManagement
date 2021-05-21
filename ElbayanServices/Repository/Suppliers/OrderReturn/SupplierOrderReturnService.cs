using System;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using System.Data.Entity;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanDatabase.DataClasses.Product;
using ElbayanServices.Repository.Suppliers.OrderReturn.Dtos;
using System.Collections.Generic;

namespace ElbayanServices.Repository.Suppliers.OrderReturn
{
    public class SupplierOrderReturnService : IOrderReturn, IDisposable
    {
        private readonly ConnectionOption _context;
        public SupplierOrderReturnService(ConnectionOption context)
        {
            _context = context;
        }
        public OrderReturnDto GetPurchaseOrderByOrderNumber(long orderNumber)
        {
            var order = _context.Orders
                              .Include(d => d.OrderProduct)
                              .Include(d => d.Clint)
                              .Where(d => d.OrderNumber == orderNumber).FirstOrDefault();
            if (order != null)
            {
                return new OrderReturnDto()
                {
                    DateTime = order.DateTime,
                    SupplierName = order.Clint.Name,
                    TotalAfterDiscount = order.TotalAfterDiscount,
                    Payment = order.Payment,
                    Deferred = order.Deferred,
                    
                    OrderReturnProduct = order.OrderProduct.Select(d => new OrderReturnProductDto()
                    {
                        ProductName = d.Name,
                        Quantity = d.Quantity,
                        PriceSale = d.PriceSale,
                        Discount = d.Discount,
                        Vat = d.Vat,
                        SubTotalPrice = d.SubTotalPrice,
                        TotalPrice = d.TotalPrice
                    }).ToList(),
                };
            }
            return null;
        }
        public Guid CreateSupplierOrderReturn(OrderReturnDto model)
        {
            var order = _context.Orders.Add(new Order()
            {
                EmployeeId = model.EmployeeId,
                IsDeferred = model.IsDeferred,
                Deferred = model.Deferred,
                DateTime = model.DateTime,
                Payment = model.Payment,
                OrderNumber = model.OrderNumber,
                IsReturn = true,
                OrderType = "مرتجع مشتريات",
                ClintId = model.ClintId,
                TotalDiscount = model.TotalDiscount,
                SubTotalWithoutDiscount = model.SubTotalWithoutDiscount,
                TotalAfterDiscount = model.TotalAfterDiscount,
                PosId = model.PosId
            });
            _context.SaveChanges();
            if (order.IsDeferred)
            {
                CreateDeferredPayments(model.ClintId, order.Deferred, order.Id, model.DueDatePayingOff);
            }
            foreach (var orderProduct in model.OrderReturnProduct)
            {
                var productPriceOnce = orderProduct.PriceSale / orderProduct.Quantity;
                //حذف كميه من المنتج
                CreateProductOrder(orderProduct, order.Id);
                //حذف كميه من المنتج في جدول المنتجات 
                SupplierProductQuantity(orderProduct.ProductId, orderProduct.Quantity);
                //اضافة الكميه الجديده الي جدول حركة المنتج 
                SupplierProductStock(orderProduct.ProductId, orderProduct.Quantity, order.Id);
                SupplierProductPrice(orderProduct.ProductId, productPriceOnce, orderProduct.Discount, orderProduct.Vat);
                _context.SaveChanges();
            }
            return order.Id;
        }
        private void SupplierProductStock(Guid productId, int quantity, Guid orderId)
        {
            _context.ProductStocks.Add(new ProductStock()
            {
                ProductId = productId,
                OrderId = orderId,
                Stock = quantity,
                Id = Guid.NewGuid(),
                DateTime = DateTime.Now,
                StockStatues = "مرتجع مشتريات "
            });
        }
        private void SupplierProductPrice(Guid productId, decimal price, decimal discount, decimal vat)
        {
            _context.ProductPrices.Add(new ProductPrice()
            {
                ProductId = productId,
                DateTime = DateTime.Now,
                Discount = discount,
                Vat = vat,
                ProcPrice = price,
                Id = Guid.NewGuid(),
                ProcessType = "مرتجع مشتريات"
            });
            _context.SaveChanges();
        }
        private void SupplierProductQuantity(Guid productId, int quantity)
        {
            var product = _context.Products.FirstOrDefault(d => d.Id == productId);

            if (product != null)
            {
                var productQuantity = product.TotalQuantity;
                productQuantity = productQuantity - quantity;
                product.TotalQuantity = productQuantity;
                _context.SaveChanges();
            }
        }
        private void CreateProductOrder(OrderReturnProductDto model, Guid orderId)
        {
            _context.OrderProducts.Add(new OrderProduct()
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
        private decimal LastPaymentLeft(Guid clintId)
        {
            var balance = _context.DeferredPayments.OrderByDescending(d => d.CreatedDate)
                .FirstOrDefault(d => d.ClintId == clintId);
            if (balance != null)
            {
                return balance.Balance;
            }

            return 0;
        }
        internal void CreateDeferredPayments(Guid clintId, decimal deferred, Guid orderId, DateTime dueDatePayingOff)
        {
            _context.DeferredPayments.Add(new DeferredPayment
            {
                Balance = LastPaymentLeft(clintId) - deferred,
                Payment = 0,
                OrderId = orderId,
                DeferredOfOrder = deferred,
                CreatedDate = DateTime.Now,
                DueDatePayingOff = dueDatePayingOff,
                TotalPayment = 0,
                ClintId = clintId,
                PaymentType = "دفع مرتجع مشتريات اجل"
            });
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
