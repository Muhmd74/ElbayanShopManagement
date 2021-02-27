using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Employees.Employees;

namespace ElbayanDatabase.DataClasses.Employees.EmployeeAccountant.EmployeeSalaryActions
{
   public class EmployeeSalaryAction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string EntryCode { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string MonthName { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<DetectionsSalary> DetectionsSalaries { get; set; }
        public ICollection<IncreasesSalary> IncreasesSalaries { get; set; }
        public decimal TotalMonthlyPaidSalary  { get; set; }


    }
}
