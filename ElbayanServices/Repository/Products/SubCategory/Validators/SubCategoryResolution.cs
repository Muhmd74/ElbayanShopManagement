using System.Linq;
using ElbayanDatabase.ConnectionTools;

namespace ElbayanServices.Repository.Products.SubCategory.Validators
{
   public static class SubCategoryResolution
    {
        public static bool IsUnique(string name)
        {
            var context = new ConnectionOption();
            var isUnique = !context.SubCategories.Any(d => d.Name == name);
            context.Dispose();
            return isUnique;
        }
    }
}
