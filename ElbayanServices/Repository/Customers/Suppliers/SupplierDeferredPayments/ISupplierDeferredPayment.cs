using System.Collections.Generic;
using ElbayanServices.Repository.Customers.DeferredPayments.Dtos;

namespace ElbayanServices.Repository.Customers.Suppliers.SupplierDeferredPayments
{
    public interface ISupplierDeferredPayment
    {
        bool Create(SupplierDeferredPaymentDto model);
        bool Update(SupplierDeferredPaymentDto model);
        List<OrderNameDto> GetOrderName();
    }
}
