using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Customers.Sales;
using ElbayanServices.Repository.Customers.DeferredPayments.Dtos;

namespace ElbayanServices.Repository.Customers.DeferredPayments
{
    public class DeferredPaymentService:IDeferredPayment , IDisposable
    {
        private readonly ConnectionOption _context;

        public DeferredPaymentService(ConnectionOption context)
        {
            _context = context;
        }

        public bool Create(DeferredPaymentDto model)
        {
            // ReSharper disable once PossibleNullReferenceException
            //Create this function In Order 
            var deferredPayment = _context.Orders.FirstOrDefault(d => d.Id == model.OrderId&&d.IsDeferred).Deferred;
            var payment = _context.DeferredPayments.Add(new DeferredPayment()
            {
                Balance = model.Balance,
                Payment = model.Payment,
                OrderId = model.OrderId,
                DeferredOfOrder = deferredPayment,
                CollectingPaymentDate = DateTime.UtcNow,
                DueDatePayingOff = model.DueDatePayingOff
            });
            _context.SaveChanges();
            return true;
        }

        public bool Update(DeferredPaymentDto model)
        {
            var deferredPayment = _context.DeferredPayments.FirstOrDefault(d => d.Id == model.Id);
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
            return _context.Orders.Where(d=>d.IsDeferred).Select(d => new OrderNameDto()
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
