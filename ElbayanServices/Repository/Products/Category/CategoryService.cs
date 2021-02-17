using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Category.Dtos;

namespace ElbayanServices.Repository.Products.Category
{
   public class CategoryService : ICategory
   {
       private readonly ConnectionOption _context;

       public CategoryService(ConnectionOption context)
       {
           _context = context;
       }

       public string Add(CategoryDto model)
       {
           try
           {
               var result = _context.Categories.Add(new ElbayanDatabase.DataClasses.Product.ProductCategory.Category()
               {
                   Name = model.Name,
                   Description = model.Description,
                   IsDeleted = false,

               });
               _context.SaveChanges();
               return result.Description;
           }
           catch (Exception e)
           {
              return e.Message;
           }
       }

        public CategoryDto Update(CategoryDto model)
        {
            var result = _context.Categories.FirstOrDefault(d => d.Id == model.Id);
            if (result!=null)
            {
                result.Description = model.Description;
                result.Name = model.Name;
                _context.SaveChanges();
                return new CategoryDto()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Id = result.Id
                };
            }

            return null;
        }

        public bool DeleteOrRestore(Guid id)
        {
            var result = _context.Categories.FirstOrDefault(d => d.Id == id);
            if (result!=null)
            {
                result.IsDeleted = !result.IsDeleted;
                _context.SaveChanges();
                return true;
            }

            return false;

        }

        public List<CategoryDto> GetAll()
        {
            var model = _context.Categories.Where(d => d.IsDeleted == false).Select(d => new CategoryDto()
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description,
            }).ToList();
            return model.Any() ? model : null;
        }
        public List<CategoryDto> GetAllDeleted()
        {
            var model = _context.Categories.Where(d => d.IsDeleted).Select(d => new CategoryDto()
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description
            }).ToList();
            return model.Any() ? model : null;
        }

        public CategoryDto GetById(Guid id)
        {
            var result = _context.Categories.FirstOrDefault(d => d.Id == id);
            if (result!=null)
            {
                return new CategoryDto()
                {
                    Name = result.Name,
                    Description = result.Description,
                    Id = result.Id
                };
            }

            return null;                                                                                                                    
        }
    }
}
