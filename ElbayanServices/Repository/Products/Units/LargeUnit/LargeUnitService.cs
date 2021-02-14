using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.LargeUnit.Validators;

namespace ElbayanServices.Repository.Products.Units.LargeUnit
{
    public class LargeUnitService : ILargeUnit
    {
        private readonly ConnectionOption _context;

        public LargeUnitService(ConnectionOption context)
        {
            _context = context;
        }

        public bool Add(LargeUnitDto model)
        {
            if (LargeUnitResolution.IsUnique(model.Name))
            {
                var result = _context.LargeUnits.Add(
                    new ElbayanDatabase.DataClasses.Product.Unit.LargeUnit()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        IsDeleted = false
                    });
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Update(LargeUnitDto model)
        {
            if (!LargeUnitResolution.IsUnique(model.Name)) return false;
            var result = _context.LargeUnits.FirstOrDefault(d => d.Id == model.Id);
            if (result == null) return false;
            result.Description = model.Description;
            result.Name = model.Name;
            _context.SaveChanges();
            return true;

        }

        public bool DeleteOrRestore(Guid id)
        {
            var model = _context.LargeUnits.FirstOrDefault(d => d.Id == id);
            if (model!=null)
            {
                model.IsDeleted = !model.IsDeleted;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<LargeUnitDto> GetAllLargeUnit()
        {
            var model = _context.LargeUnits.Where(d=>d.IsDeleted==false).Select(d => new LargeUnitDto()
            {
                Description = d.Description,
                Name = d.Name,
                IsDeleted = d.IsDeleted
            }).ToList();
            return model;
        }

        public LargeUnitDto Get(Guid id)
        {
            var model = _context.LargeUnits.FirstOrDefault(d => d.Id == id);

            if (model!=null)
            {
                return new LargeUnitDto()
                {
                    Description = model.Description,
                    Name = model.Name,
                    IsDeleted = model.IsDeleted
                };
            }

            return null;
        }
    }
}
