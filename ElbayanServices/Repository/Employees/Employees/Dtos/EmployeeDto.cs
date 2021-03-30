using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Employees.Employees.Dtos
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public string Mobile { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Identity { get; set; }
        public DateTime IdentityExpirationDate { get; set; }
        public string PassportNumber { get; set; }
        public DateTime PassportExpirationDate { get; set; }
        public string ResidenceType { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

    }
}
