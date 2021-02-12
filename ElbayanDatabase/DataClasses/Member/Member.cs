using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Member
{
    public class Member
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public bool IsActive { get; set; }
        public ICollection<MemberRole> MemberRoles { get; set; }

    }
}
