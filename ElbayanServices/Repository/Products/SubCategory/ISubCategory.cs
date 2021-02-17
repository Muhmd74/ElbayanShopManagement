using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Products.SubCategory.Dtos;

namespace ElbayanServices.Repository.Products.SubCategory
{
    public interface ISubCategory
    {
        SubCategoryDto Add(SubCategoryDto model);
        SubCategoryDto Update(SubCategoryDto model);
        bool DeleteOrRestore(Guid id);
        List<SubCategoryDto> GetAll();
        List<SubCategoryDto> GetAllIsDeleted();
        SubCategoryDto GetById(Guid id);
        SubCategoryDto GetByName(string subCategoryName);

    }
}
