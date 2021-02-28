using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Customers.Sales;
using ElbayanDatabase.DataClasses.Suppliers.SupplierOrder;
using ElbayanServices.Repository.Customers.DeferredPayments.Dtos;

namespace ElbayanServices.Repository.Customers.Suppliers.SupplierDeferredPayments
{
    public class SupplierDeferredPaymentService:ISupplierDeferredPayment , IDisposable
    {
        private readonly ConnectionOption _context;

        public SupplierDeferredPaymentService(ConnectionOption context)
        {
            _context = context;
        }

        public bool Create(SupplierDeferredPaymentDto model)
        {
            // ReSharper disable once PossibleNullReferenceException
            //Create this function In Order 
            var deferredPayment = _context.SupplierOrders.FirstOrDefault(d => d.Id == model.OrderId&&d.IsDeferred).Deferred;
            var payment = _context.SupplierDeferredPayments.Add(new SupplierDeferredPayment()
            {
                Balance = model.Balance,
                Payment = model.Payment,
                SupplierOrderId = model.OrderId,
                DeferredOfOrder = deferredPayment,
                CollectingPaymentDate = DateTime.UtcNow,
                DueDatePayingOff = model.DueDatePayingOff,
                TotalPayment = model.TotalPayment
            });
            _context.SaveChanges();
            return true;
        }

        public bool Update(SupplierDeferredPaymentDto model)
        {
            var deferredPayment = _context.SupplierDeferredPayments.FirstOrDefault(d => d.Id == model.Id);
            if (deferredPayment!=null)
            {
                deferredPayment.Payment = model.Payment;
                deferredPayment.Balance -= model.Payment;
                deferredPayment.CollectingPaymentDate=DateTime.UtcNow;
                deferredPayment.DueDatePayingOff = model.DueDatePayingOff;
                deferredPayment.TotalPayment += model.Payment;
                _context.SaveChanges();
                return true;
            }

            return false;

        }

        public List<OrderNameDto> GetOrderName()
        {
            return _context.SupplierOrders.Where(d=>d.IsDeferred).Select(d => new OrderNameDto()
            {
                Id = d.Id,
                OrderNumber = d.OrderNumber
            }).ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
            
        }
    }
}
