using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElbayanDatabase.DataClasses.Employees.CashierDrawers
{
   public class DrawerTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Type { get; set; }
        public Guid CashierDrawerId { get; set; }
        public CashierDrawer CashierDrawer { get; set; }

      //  public Guid OrderId { get; set; }
    }
}
