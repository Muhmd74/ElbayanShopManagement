using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Customers.Sales
{
   public class PaymentType
    {
      

        public Guid Id { get; set; }
        public decimal Cash { get; set; }
        public Guid DeferredPaymentId { get; set; }
        public DeferredPayment  DeferredPayment { get; set; }

    }
}
