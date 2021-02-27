using System;
using System.Collections.Generic;
using ElbayanDatabase.DataClasses.Suppliers.Supplier;

namespace ElbayanDatabase.DataClasses.Customers
{
   public class CustomerType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsSupplier { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
