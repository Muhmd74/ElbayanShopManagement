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
        List<ProductStockDetails> GetAllProductStockDetails();
        List<ProductStockDetails> GetAllProductStockDetailsByDateTime(DateTime firstDateTime , DateTime lastDateTime,string orderType);
        List<ProductStockDetails> GetAllProductStockDetailsByType(string orderType);
        List<ProductStockDetails> GetAllProductStockDetailsSearch(string productName,long barCode);
    }
}
