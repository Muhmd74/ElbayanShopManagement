using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Customers.Sales
{
   public class DeferredPayment
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public decimal DeferredAmount { get; set; }
        public DateTime DueDatePayingOff { get; set; }
    }
}
