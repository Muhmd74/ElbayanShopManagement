using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Member;

namespace ElbayanDatabase.DataClasses.Employees.Employees
{
   public class EmployeePermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
