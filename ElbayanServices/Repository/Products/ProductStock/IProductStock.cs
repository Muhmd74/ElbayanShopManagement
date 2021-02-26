using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Products.ProductStock.Dtos;

namespace ElbayanServices.Repository.Products.ProductStock
{
    public interface IProductStock
    {
        bool CreateOpeningBalancesProduct(ProductStockDto model);
    }
}
