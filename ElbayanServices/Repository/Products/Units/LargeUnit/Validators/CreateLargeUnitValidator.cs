using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;

namespace ElbayanServices.Repository.Products.Units.LargeUnit.Validators
{
    public class CreateLargeUnitValidator 
    {
        public static bool IsUnique(string name)
        {
            var context = new ConnectionOption();
            var largeName = context.LargeUnits.Any(d => d.Name == name);
            context.Dispose();
            return largeName;
        }
    }
}
