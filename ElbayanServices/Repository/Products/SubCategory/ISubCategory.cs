using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Products.SubCategory.Dtos;

namespace ElbayanServices.Repository.Products.SubCategory
{
    public interface ISubCategory
    {
        SubCategoryDto Add(SubCategoryDto model);
        SubCategoryDto Update(SubCategoryDto model);
        bool Delete(Guid id);
        List<SubCategoryDto> GetAll();
        SubCategoryDto GetById(Guid id);

    }
}
