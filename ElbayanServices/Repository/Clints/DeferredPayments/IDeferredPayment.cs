using System.Collections.Generic;
using ElbayanServices.Repository.Clints.DeferredPayments.Dtos;

namespace ElbayanServices.Repository.Clints.DeferredPayments
{
    public interface IDeferredPayment
    {
        bool Create(SupplierDeferredPaymentDto model);
        bool PayingDeferred(SupplierDeferredPaymentDto model);
        bool Update(SupplierDeferredPaymentDto model);
        List<OrderNameDto> GetOrderName();
    }
}
