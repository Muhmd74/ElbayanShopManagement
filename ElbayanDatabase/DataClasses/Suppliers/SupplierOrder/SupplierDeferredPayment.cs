using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Customers.Sales;

namespace ElbayanDatabase.DataClasses.Suppliers.SupplierOrder
{
  public class SupplierDeferredPayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid SupplierOrderId { get; set; }
        public SupplierOrder SupplierOrder { get; set; }
        public decimal DeferredOfOrder { get; set; } //المتبقي
        public decimal Payment { get; set; }
        public decimal TotalPayment { get; set; }
        public decimal Balance { get; set; }//  in add DeferredOfOrder in update Balance - Payment
        public DateTime DueDatePayingOff { get; set; }
        public DateTime CollectingPaymentDate { get; set; }
    }
}
