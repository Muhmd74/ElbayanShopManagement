using System;

namespace ElbayanServices.Repository.Customers.Suppliers.Supplier.Dtos
{
    public class SupplierDeferredDto
    {
        public Guid Id { get; set; }
        public Guid SupplierOrderId { get; set; }
        public string SupplierName { get; set; }
        public int SupplierOrderNumber { get; set; }
        public decimal DeferredOfOrder { get; set; } //المتبقي
        public decimal Payment { get; set; }
        public decimal TotalPayment { get; set; }
        public decimal Balance { get; set; }//  in add DeferredOfOrder in update Balance - Payment
        public DateTime DueDatePayingOff { get; set; }
        public DateTime CollectingPaymentDate { get; set; }
    }
}
