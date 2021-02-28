using System;

namespace ElbayanServices.Repository.Customers.Suppliers.SupplierDeferredPayments.Dtos
{
  public  class SupplierDeferredPaymentDto
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public decimal DeferredOfOrder { get; set; } //المتبقي
        public decimal Payment { get; set; }
        public decimal Balance { get; set; }//  in add DeferredOfOrder in update Balance - Payment
        public DateTime DueDatePayingOff { get; set; }
        public DateTime CollectingPaymentDate { get; set; }
        public decimal TotalPayment { get; set; }

    }
}
