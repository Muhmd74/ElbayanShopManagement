using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Employees.Employees;

namespace ElbayanDatabase.DataClasses.Authentications
{
   public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(450)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<RoleTemplate> RolesTemplates { get; set; }
        public ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}
