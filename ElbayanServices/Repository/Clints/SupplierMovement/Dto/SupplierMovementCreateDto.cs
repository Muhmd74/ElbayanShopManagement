using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Clints.SupplierMovement.Dto
{
    public class SupplierMovementCreateDto
    {
        public decimal DeferredOfOrder { get; set; } //المتبقي
        public decimal Payment { get; set; }
        public string PaymentType { get; set; }// نوع الدفع كاش ولا بنك 
        public decimal TotalPayment { get; set; }
        public decimal Balance { get; set; }//مدين  in add DeferredOfOrder in update Balance - Payment
        public decimal DeferredPayment { get; set; } //دائن 
        public DateTime DueDatePayingOff { get; set; }
        public DateTime CollectingPaymentDate { get; set; }
        public Guid? ClintId { get; set; }
        public string Description { get; set; }
        public long DepositNumber { get; set; }

    }
}
