using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;

namespace ElbayanServices.Repository.Employees.Employees.Validators
{
  public  class EmployeeResolution
    {
        public static bool MobileIsUnique(string mobile)
        {
            var context = new ConnectionOption();
            var isUnique = !context.Employees.Any(d => d.Mobile == mobile);
            context.Dispose();
            return isUnique;
        }

        public static bool EmailIsUnique(string email)
        {
            var context = new ConnectionOption();
            var isUnique = !context.Employees.Any(d => d.Email == email);
            context.Dispose();
            return isUnique;
        }
    }
}
