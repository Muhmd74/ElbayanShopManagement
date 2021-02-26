using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Customers
{
   public class CustomerType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
