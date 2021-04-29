using System;

namespace ElbayanServices.Repository.Suppliers.SupplierMovement.Dto
{
   public class SupplierMovementDto
    {
        //Order
        public Guid? ClintId { get; set; }
        public string ClintName { get; set; }
        public decimal DepositNumber { get; set; }
        //Deferred
        public DateTime CollectingPaymentDate { get; set; }
        public DateTime DueDatePayingOff { get; set; }
        public string PaymentType { get; set; }// نوع الدفع كاش ولا بنك 
        public decimal Balance { get; set; }//مدين
        public decimal Payment { get; set; } //دائن
        public long OrderNumber { get; set; }

    }
}
