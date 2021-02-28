using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Customers.Sales;
using ElbayanDatabase.DataClasses.Suppliers.SupplierOrder;
using ElbayanServices.Repository.Customers.Suppliers.SupplierOrder.Dtos;

namespace ElbayanServices.Repository.Customers.Suppliers.SupplierOrder
{
   public class SupplierOrderService:ISupplierOrder
   {
       private readonly ConnectionOption _context;

       public SupplierOrderService(ConnectionOption context)
       {
           _context = context;
       }

       public bool CreateSupplierOrder(SupplierOrderDto model)
       {
            var order = _context.SupplierOrders.Add(new ElbayanDatabase.DataClasses.Suppliers.SupplierOrder.SupplierOrder
            {
           
                EmployeeId = model.EmployeeId,
                IsDeferred = model.IsDeferred,
                Deferred = model.Deferred,
                DateTime = model.DateTime,
                Payment = model.Payment
            });
            _context.SaveChanges();
            if (order.IsDeferred)
            {
                var payment = _context.SupplierDeferredPayments.Add(new SupplierDeferredPayment()
                {
                    Balance = order.Deferred,
                    Payment = 0,
                    SupplierOrderId = order.Id,
                    DeferredOfOrder = order.Deferred,
                    CollectingPaymentDate = DateTime.UtcNow,
                    DueDatePayingOff = model.DueDatePayingOff,
                    TotalPayment = 0
                });
                _context.SaveChanges();
            }

            if (order != null)
            {
                foreach (var orderProduct in model.SupplierOrderProducts)
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
                }
                _context.SaveChanges();
                var orderTable = _context.SupplierOrders.FirstOrDefault(d => d.Id == order.Id);
                orderTable.TotalDiscount = model.TotalDiscount;
                orderTable.SubTotalWithoutDiscount = model.SubTotalWithoutDiscount;
                orderTable.TotalAfterDiscount = model.TotalAfterDiscount;
                _context.SaveChanges();


            }
            return true;
        }
   }
}
