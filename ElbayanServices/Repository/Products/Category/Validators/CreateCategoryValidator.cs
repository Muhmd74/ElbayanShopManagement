using System.Linq;
using ElbayanDatabase.ConnectionTools;

namespace ElbayanServices.Repository.Products.Category.Validators
{
    public class CreateCategoryValidator 
    {
        public static bool IsUnique(string name)
        {
            var context = new ConnectionOption();
            var largeName = context.Categories.Any(d => d.Name == name);
            context.Dispose();
            return largeName;
        }
    }
}
