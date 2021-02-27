using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElbayanDatabase.DataClasses.Employees.EmployeeAccountant.Salary
{
   public class Commission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Value { get; set; }
        public Guid EmployeeSalaryId { get; set; }
        public EmployeeSalary EmployeeSalary { get; set; }
    }
}
