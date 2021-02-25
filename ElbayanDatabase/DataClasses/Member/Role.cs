using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Employees;
using ElbayanDatabase.DataClasses.Employees.Employees;

namespace ElbayanDatabase.DataClasses.Member
{
   public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<MemberRole> MemberRoles { get; set; }
        public ICollection<EmployeePermission> EmployeePermissions { get; set; }
    }
}
