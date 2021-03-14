using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanDatabase.DataClasses.Employees.CashierDrawers;
using ElbayanDatabase.DataClasses.Employees.EmployeeAccountant.EmployeeSalaryActions;
using ElbayanDatabase.DataClasses.Employees.EmployeeAccountant.Salary;

namespace ElbayanDatabase.DataClasses.Employees.Employees
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(450)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(450)]
        [Index(IsUnique = true)]
        public string UserName { get; set; }
        //[Required]
        //public string UserType { get; set; }

        //public Guid? ScreenProfileId{ get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsActive { get; set; } = true;
        [Required]
        public string Mobile { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        //public Guid SettingProfileId { get; set; }
        //public SettingProfile SettingProfile { get; set; }
        
        public string Identity { get; set; }
        public DateTime IdentityExpirationDate { get; set; }
        public string PassportNumber { get; set; }
        public DateTime PassportExpirationDate { get; set; }
        public string ResidenceType { get; set; }
        public Users Users { get; set; }
        public ICollection<EmployeeRole> EmployeeRoles { get; set; }
        public ICollection<EmployeeSalaryAction> EmployeeSalaryActions { get; set; }
        public ICollection<EmployeeSalary> EmployeeSalaries { get; set; }
        public ICollection<CashierDrawer> CashierDrawers { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

    public enum TypeOfResidence
    {
        Resident,
        HomeResident
    }

}
