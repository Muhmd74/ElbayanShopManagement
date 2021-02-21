using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Customers.Sales
{
   public class Order
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal SubTotalWithoutDiscount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalAfterDiscount { get; set; }
        public ICollection<DeferredPayment> DeferredPayments { get; set; }
        
        

    }
}
