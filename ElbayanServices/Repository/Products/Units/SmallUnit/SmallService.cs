using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Validators;

namespace ElbayanServices.Repository.Products.Units.SmallUnit
{
    public class SmallService : ISmallUnit
    {
        private readonly ConnectionOption _context;

        public SmallService(ConnectionOption context)
        {
            _context = context;
        }

        public bool Add(SmallUnitDto model)
        {
          
                var result = _context.SmallUnits.Add(
                    new ElbayanDatabase.DataClasses.Product.Unit.SmallUnit()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        IsDeleted = false
                    });
                _context.SaveChanges();
                return true;
     

        }

        public bool Update(SmallUnitDto model)
        {
           
                var result = _context.SmallUnits.FirstOrDefault(d => d.Id == model.Id);
                if (result == null) return false;
                result.Description = model.Description;
                result.Name = model.Name;
                _context.SaveChanges();
                return true;

        }

        public bool DeleteOrRestore(Guid id)
        {
            var model = _context.SmallUnits.FirstOrDefault(d => d.Id == id);
            if (model != null)
            {
                model.IsDeleted = !model.IsDeleted;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<SmallUnitDto> GetAllSmallUnit()
        {
            var model = _context.SmallUnits.Where(d=>d.IsDeleted==false).Select(d => new SmallUnitDto()
            {
                Description = d.Description,
                Name = d.Name,
                IsDeleted = d.IsDeleted,
                Id = d.Id
            }).ToList();
            return model;
        }


        public List<SmallUnitDto> GetAllSmallUnitDeleted()
        {
            var model = _context.SmallUnits.Where(d=>d.IsDeleted).Select(d => new SmallUnitDto()
            {
                Description = d.Description,
                Name = d.Name,
                IsDeleted = d.IsDeleted,
                Id = d.Id
            }).ToList();
            return model;
        }

        public SmallUnitDto Get(Guid id)
        {
            var model = _context.SmallUnits.FirstOrDefault(d => d.Id == id);

            if (model != null)
            {
                return new SmallUnitDto()
                {
                    Description = model.Description,
                    Name = model.Name,
                    IsDeleted = model.IsDeleted
                };
            }

            return null;
        }

        public SmallUnitDto GetByName(string smallName)
        {
            var model = _context.LargeUnits.FirstOrDefault(d => d.Name == smallName && d.IsDeleted == false);

            if (model != null)
            {
                return new SmallUnitDto()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Id = model.Id
                };
            }

            return null;
        }
    }
}

