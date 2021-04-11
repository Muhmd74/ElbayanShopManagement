using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElbayanDatabase.DataClasses.Employees.Employees
{
    public  class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(250)]
        [Index(IsUnique = true)]
        public string UserName { get; set; }
        [Required] 
        public string Password { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public bool IsDeleted { get; set; }
    }
}
