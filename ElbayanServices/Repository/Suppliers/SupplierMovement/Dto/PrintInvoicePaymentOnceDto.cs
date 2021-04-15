using System;

namespace ElbayanServices.Repository.Suppliers.SupplierMovement.Dto
{
   public class PrintInvoicePaymentOnceDto
    {
        //firm
        public string FirmName { get; set; }
        public int? Mobile { get; set; }
        public string LogoInvoice { get; set; }
        public string MessageInvoice { get; set; }
        //supplier
        
        public string Description { get; set; }
        public string ClintName { get; set; }
        public string ClintMobile { get; set; }
        public decimal? DepositNumber { get; set; }
        public decimal? Payment { get; set; } // قيمة الدفعه الواحدة 
        public string? PaymentType { get; set; }// نوع الدفع كاش ولا بنك 
        public decimal? TotalPayment { get; set; } //ناتج جمع الدفعات //دائن  
        public decimal? Balance { get; set; }// ناتج الديون بعد طرع الدفعات منها مدين  in add DeferredOfOrder in update Balance - Payment
        public DateTime DueDatePayingOff { get; set; }
        public DateTime CollectingPaymentDate { get; set; }
        public Guid? ClintId { get; set; }
    }
}
