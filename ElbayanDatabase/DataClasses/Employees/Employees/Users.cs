using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Employees.Employees
{
  public  class Users
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(250)]
        [Index(IsUnique = true)]
        public string UserName { get; set; }
        [Required] 
        public string Password { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
