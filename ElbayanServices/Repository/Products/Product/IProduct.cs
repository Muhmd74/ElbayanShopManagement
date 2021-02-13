using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Products.Product.Dtos;

namespace ElbayanServices.Repository.Products.Product
{
   public interface IProduct
   {
       bool Add(ProductDto model);
       bool Update(ProductDto model);
       bool IsDeleted(Guid id);
       List<ProductDto> GetAllProductDeleted();
       List<ProductDto> GetAll();
       ProductDto GetById(Guid id);
       List<ProductNameDto> GetAllProductName();
   }
}
