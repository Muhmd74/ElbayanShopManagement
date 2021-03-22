using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Common;
using ElbayanServices.Repository.Products.ProductStock.Dtos;

namespace ElbayanServices.Repository.Products.ProductStock
{
   public class ProductStockService : IProductStock ,IDisposable
   {
       private readonly ConnectionOption _context;

       public ProductStockService(ConnectionOption context)
       {
           _context = context;
       }

       public bool CreateOpeningBalancesProduct(ProductStockDto model)
       {
           var productStock = _context.ProductStocks.Add(new ElbayanDatabase.DataClasses.Product.ProductStock
           {
               Stock = model.Stock,
               ProductId = model.ProductId
           });
           _context.SaveChanges();
           var productQuantity = _context.Products.FirstOrDefault(d => d.Id == model.ProductId);
           if (productQuantity!=null)
           {
               productQuantity.TotalQuantity += model.Stock;
               _context.SaveChanges();
               return true;
           }

           return false;

       }

      
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
