using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Clints.SupplierMovement.Dto
{
   public class PaymentAllDeferredDto
    {
        public Guid ClintId { get; set; }
        public string PaymentType { get; set; }
        public string Description { get; set; }
        public long DepositNumber { get; set; }
    }
}
