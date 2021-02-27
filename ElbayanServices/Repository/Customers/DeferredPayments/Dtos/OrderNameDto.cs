using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Customers.DeferredPayments.Dtos
{
 public class OrderNameDto
    {
        public Guid Id { get; set; }
        public int OrderNumber { get; set; }

    }
}
