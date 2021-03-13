using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Employees.Employees
{
    public class EmployeeRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Role Role { get; set; }
        public Guid RoleId { get; set; }
    }
}
