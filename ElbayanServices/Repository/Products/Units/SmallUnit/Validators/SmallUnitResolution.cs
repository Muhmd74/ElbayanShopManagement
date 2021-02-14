using System.Linq;
using ElbayanDatabase.ConnectionTools;

namespace ElbayanServices.Repository.Products.Units.SmallUnit.Validators
{
   public class SmallUnitResolution
    {
        public static bool IsUnique(string name)
        {
            var context = new ConnectionOption();
            var smallUnit = context.SmallUnits.Any(d => d.Name == name);
            context.Dispose();
            return smallUnit;
        }
    }
}
