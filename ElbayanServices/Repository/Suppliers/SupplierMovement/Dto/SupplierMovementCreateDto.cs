using System;

namespace ElbayanServices.Repository.Suppliers.SupplierMovement.Dto
{
    public class SupplierMovementCreateDto
    {
         public decimal Payment { get; set; }
        public string PaymentType { get; set; }// نوع الدفع كاش ولا بنك 
        public decimal TotalPayment { get; set; }
        public decimal Balance { get; set; }//مدين  in add DeferredOfOrder in update Balance - Payment
         public DateTime DueDatePayingOff { get; set; }
        public DateTime CollectingPaymentDate { get; set; }
        public Guid? ClintId { get; set; }
        public string Description { get; set; }
        public long DepositNumber { get; set; }

    }
}
