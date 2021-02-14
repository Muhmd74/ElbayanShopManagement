using System.Linq;
using ElbayanDatabase.ConnectionTools;

namespace ElbayanServices.Repository.Products.Units.LargeUnit.Validators
{
   public class LargeUnitResolution
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
