using System;
using System.Collections.Generic;

namespace ElbayanDatabase.DataClasses.Customers.Sales
{
   public class POS
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? BuildingId { get; set; }
        public Building Building { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
