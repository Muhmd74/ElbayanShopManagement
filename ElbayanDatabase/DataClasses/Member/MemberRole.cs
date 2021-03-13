using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Employees.Employees;

namespace ElbayanDatabase.DataClasses.Member
{
  public  class MemberRole
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
