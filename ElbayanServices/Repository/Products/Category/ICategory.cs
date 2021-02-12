using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Products.Category.Dtos;

namespace ElbayanServices.Repository.Products.Category
{
    public interface ICategory
    {
        CategoryDto Add(CategoryDto model);
        CategoryDto Update(CategoryDto model);
        bool DeleteOrRestore(Guid id);
        List<CategoryDto> GetAll();
        CategoryDto GetById(Guid id);

    }
}
