using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Customers.DeferredPayments.Dtos;

namespace ElbayanServices.Repository.Customers.DeferredPayments
{
    public interface IDeferredPayment
    {
        bool Create(SupplierDeferredPaymentDto model);
        bool Update(SupplierDeferredPaymentDto model);
        List<OrderNameDto> GetOrderName();
    }
}
