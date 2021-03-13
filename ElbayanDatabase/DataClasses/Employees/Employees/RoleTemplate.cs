using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Employees.Employees
{
   public class RoleTemplate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public Template Template { get; set; }
        public Guid TemplateId { get; set; }
    }
}
