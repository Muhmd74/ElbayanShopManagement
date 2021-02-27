using System;
using System.Collections.Generic;

namespace ElbayanDatabase.DataClasses.Customers
{
   public class CustomerType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
