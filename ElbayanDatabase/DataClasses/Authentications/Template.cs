using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElbayanDatabase.DataClasses.Authentications
{
   public class Template
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(450)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public ICollection<RoleTemplate> RolesTemplates { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
