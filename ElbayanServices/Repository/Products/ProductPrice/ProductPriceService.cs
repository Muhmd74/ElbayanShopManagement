using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.ProductPrice.Dto;

namespace ElbayanServices.Repository.Products.ProductPrice
{
  public  class ProductPriceService : IProductPrice , IDisposable
  {
      private readonly ConnectionOption _context;

      public ProductPriceService(ConnectionOption context)
      {
          _context = context;
      }

      public List<MovementProductPriceDto> GetAllProductPrice()
      {
          return _context.ProductPrices.Select(d => new MovementProductPriceDto()
          {
              BarCode = d.Product.BarCode,
              DateTime = d.DateTime,
              Discount=d.Discount,
          }).ToList();
      }

        public List<MovementProductPriceDto> GetAllProductPriceByDateTime(DateTime? firstDateTime, DateTime? lastDateTime, string? orderType, Guid? productId)
        {
            throw new NotImplementedException();
        }

        public List<MovementProductPriceDto> GetAllProductPriceByType(string orderType)
        {
            throw new NotImplementedException();
        }

        public List<MovementProductPriceDto> GetAllProductPriceSearch(string productName, long barCode)
        {
            throw new NotImplementedException();
        }

        public int GetProductQuantity(Guid productId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
