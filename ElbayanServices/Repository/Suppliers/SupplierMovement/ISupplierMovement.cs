using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Suppliers.SupplierMovement.Dto;

namespace ElbayanServices.Repository.Suppliers.SupplierMovement
{
    public interface ISupplierMovement
    {
        Guid CreatePayment(SupplierMovementCreateDto model);
        Guid PaymentAllDeferred(PaymentAllDeferredDto model);
        GetSupplierPaymentByUserDto GetLastPaymentByUserId(Guid clintId);
        PrintInvoicePaymentOnceDto PrintInvoicePaymentOnce(Guid id);
        List<SupplierMovementDto> GetAllSupplierMovement();
        List<GetAllMovementOrderInOneDayDto> GetAllMovementOrderInOneDay();
        List<SupplierMovementDto> GetAllSupplierMovementByClintId(Guid clintId);
        List<SupplierMovementDto> FilterPaymentsByDate( DateTime firstDate, DateTime lastDate, Guid? clintId, string paymentType);
    }
}
