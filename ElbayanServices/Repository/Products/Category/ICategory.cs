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
        string Add(CategoryDto model);
        CategoryDto Update(CategoryDto model);
        bool DeleteOrRestore(Guid id);
        List<CategoryDto> GetAll();
        List<CategoryDto> GetAllDeleted();
        CategoryDto GetById(Guid id);
        CategoryDto GetByName(string categoryName);

    }
}
