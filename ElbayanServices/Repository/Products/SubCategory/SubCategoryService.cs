using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.SubCategory.Dtos;

namespace ElbayanServices.Repository.Products.SubCategory
{
   public class SubCategoryService : ISubCategory
   {
       private readonly ConnectionOption _context;

       public SubCategoryService(ConnectionOption context)
       {
           _context = context;
       }

       public SubCategoryDto Add(SubCategoryDto model)
       {
           try
           {
               var result = _context.SubCategories.Add(new ElbayanDatabase.DataClasses.Product.ProductCategory.SubCategory
               {
                   Name = model.Name,
                   Description = model.Description,
                   CategoryId = model.CategoryId

               });
               _context.SaveChanges();
               return new SubCategoryDto()
               {
                   Name = model.Name,
                   Description = model.Description,
                   Id = result.Id
               };
           }
           catch (Exception e)
           {
              return null;
           }
       }

        public SubCategoryDto Update(SubCategoryDto model)
        {
            var result = _context.SubCategories.FirstOrDefault(d => d.Id == model.Id);
            if (result!=null)
            {
                result.Description = model.Description;
                result.Name = model.Name;
                result.CategoryId = model.CategoryId;
                _context.SaveChanges();
                return new SubCategoryDto()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Id = result.Id
                };
            }

            return null;
        }

        public bool Delete(Guid id)
        {
            var result = _context.SubCategories.FirstOrDefault(d => d.Id == id);
            if (result!=null)
            {
                _context.SubCategories.Remove(result);
                _context.SaveChanges();
                return true;
            }

            return false;

        }

        public List<SubCategoryDto> GetAll()
        {
            var model = _context.SubCategories
                .Select(d => new SubCategoryDto()
            {
                Name = d.Name,
                Description = d.Description,
                CategoryId = d.CategoryId,
                CategoryName = d.Category.Name
            }).ToList();
            return model.Any() ? model : null;
        }

        public SubCategoryDto GetById(Guid id)
        {
            var result = _context.SubCategories.FirstOrDefault(d => d.Id == id);
            if (result!=null)
            {
                return new SubCategoryDto()
                {
                    Name = result.Name,
                    Description = result.Description,
                    CategoryId = result.CategoryId,
                    CategoryName = result.Category.Name,
                    Id = result.Id
                };
            }

            return null;                                                                                   
        }
    }
}
