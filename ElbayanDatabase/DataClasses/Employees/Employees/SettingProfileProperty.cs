using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Employees.Employees
{
   public class SettingProfileProperty
    {
        public Guid Id { get; set; }
        public string PropertyName { get; set; }
        public byte[] PropertyValue { get; set; }
        public Guid SettingProfileId { get; set; }
        public SettingProfile SettingProfile { get; set; }
    }
}
