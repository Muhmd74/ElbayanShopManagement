using System;

namespace ElbayanServices.Repository.Suppliers.SupplierMovement.Dto
{
   public class PaymentAllDeferredDto
    {
        public Guid ClintId { get; set; }
        public string PaymentType { get; set; }
        public string Description { get; set; }
        public long DepositNumber { get; set; }
        public decimal TotalPayment { get; set; }
    }
}
