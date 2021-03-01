using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Employees.Employees;

namespace ElbayanDatabase.DataClasses.Employees.EmployeeAccountant.Salary
{
   public class EmployeeSalary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public decimal BasicSalary { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public decimal TotalSalary { get; set; }
        public ICollection<Commission> Commissions { get; set; }
        public ICollection<Allowance> Allowances { get; set; }



    }
}
