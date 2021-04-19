using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElbayanDatabase.DataClasses.Clints.Sales
{
   public class DeferredPayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid? OrderId { get; set; }
        public Order Order { get; set; }
        public decimal DeferredOfOrder { get; set; } //المتبقي
        public decimal Payment { get; set; }
        public string PaymentType { get; set; }// نوع الدفع كاش ولا بنك 
        public decimal TotalPayment { get; set; }
        public long DepositNumber { get; set; } 
        public string Description { get; set; }
        public decimal Balance { get; set; }//  in add DeferredOfOrder in update Balance - Payment
        public DateTime DueDatePayingOff { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ClintId { get; set; }
        public Clint Clint { get; set; }

    }
}
