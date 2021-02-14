using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;

namespace ElbayanServices.Repository.Products.Product.Validators
{
   public class ProductResolution
    {
        public static bool IsUnique(string name)
        {
            var context = new ConnectionOption();
            var isUnique = !context.Products.Any(d => d.Name == name);
            context.Dispose();
            return isUnique;
        }
        public static bool BarCodeIsUnique(int barCode)
        {
            var context = new ConnectionOption();
            var barCodeIsUnique = !context.Products.Any(d => d.BarCode == barCode);
            context.Dispose();
            return barCodeIsUnique;
        }
    }
}
