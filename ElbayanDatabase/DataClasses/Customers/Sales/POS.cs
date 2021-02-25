using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Employees.CashierDrawers;

namespace ElbayanDatabase.DataClasses.Customers.Sales
{
   public class POS
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CashierDrawer> CashierDrawers { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
