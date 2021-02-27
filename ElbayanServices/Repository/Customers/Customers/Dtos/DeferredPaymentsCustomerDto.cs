using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Customers.Customers.Dtos
{
    public class DeferredPaymentsCustomerDto
    {
        public decimal DeferredOfOrder { get; set; } //المتبقي
        public decimal Payment { get; set; }
        public decimal Balance { get; set; }//  in add DeferredOfOrder in update Balance - Payment
        public DateTime DueDatePayingOff { get; set; }
    }
}
