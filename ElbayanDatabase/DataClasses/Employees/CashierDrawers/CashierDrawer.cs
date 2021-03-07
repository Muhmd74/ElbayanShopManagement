using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanDatabase.DataClasses.Employees.Employees;

namespace ElbayanDatabase.DataClasses.Employees.CashierDrawers
{
    public class CashierDrawer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Location { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Guid PosId { get; set; }
        public POS Pos { get; set; }
        public decimal DrawerBalance { get; set; }
        public ICollection<DailyOffShift> DailyOffShifts { get; set; }
        public ICollection<DrawerTransaction> DrawerTransactions { get; set; }


    }
}
