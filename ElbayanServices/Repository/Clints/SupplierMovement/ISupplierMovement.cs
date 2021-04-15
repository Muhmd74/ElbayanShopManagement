using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Clints.SupplierMovement.Dto;

namespace ElbayanServices.Repository.Clints.SupplierMovement
{
    public interface ISupplierMovement
    {
        Guid CreatePayment(SupplierMovementCreateDto model);
        Guid PaymentAllDeferred(PaymentAllDeferredDto model);
        GetSupplierPaymentByUserDto GetLastPaymentByUserId(Guid clintId);
        PrintInvoicePaymentOnceDto PrintInvoicePaymentOnce(Guid id);
        List<SupplierMovementDto> GetAllSupplierMovement();
        List<SupplierMovementDto> GetAllSupplierMovementByClintId(Guid clintId);
        List<SupplierMovementDto> FilterPaymentsByDate( DateTime firstDate, DateTime lastDate, Guid? clintId, string paymentType);
    }
}
