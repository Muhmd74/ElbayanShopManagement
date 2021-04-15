using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Clints.SupplierMovement.Dto
{
   public class GetSupplierPaymentByUserDto
    {
        public decimal Balance { get; set; }
        public decimal Payment { get; set; }
        public string ClintName { get; set; }
    }
}
