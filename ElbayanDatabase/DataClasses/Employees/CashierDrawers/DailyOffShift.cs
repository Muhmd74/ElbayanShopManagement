using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElbayanDatabase.DataClasses.Employees.CashierDrawers
{
   public class DailyOffShift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime EndShift { get; set; }
        public decimal TotalMoneyOffShift { get; set; }
        public Guid CashierDrawerId { get; set; }

        public CashierDrawer CashierDrawer { get; set; }
       // public Guid AccountId { get; set; }

    }
}
