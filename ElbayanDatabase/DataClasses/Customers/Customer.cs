using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Customers.Sales;

namespace ElbayanDatabase.DataClasses.Customers
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int IdNumber { get; set; }
        public string Address { get; set; }
        public int CustomerNumber { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}
