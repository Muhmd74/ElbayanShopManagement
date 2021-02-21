using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Customers.Sales
{
  public  class Sale
    {
        public Guid Id { get; set; }
        public Guid POSId { get; set; }
        public POS Pos { get; set; }
    }
}
