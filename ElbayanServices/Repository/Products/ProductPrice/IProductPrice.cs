using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Products.ProductPrice.Dto;
using ElbayanServices.Repository.Products.ProductStock.Dtos;

namespace ElbayanServices.Repository.Products.ProductPrice
{
    public interface IProductPrice
    {
        List<MovementProductPriceDto> GetAllProductPrice();
        List<MovementProductPriceDto> GetAllProductPriceByDateTime(DateTime? firstDateTime, DateTime? lastDateTime, string? orderType, Guid? productId);
        List<MovementProductPriceDto> GetAllProductPriceByType(string orderType);
        List<MovementProductPriceDto> GetAllProductPriceSearch(string productName, long barCode);
        int GetProductQuantity(Guid productId);
    }
}
