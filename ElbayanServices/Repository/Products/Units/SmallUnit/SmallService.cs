using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;

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
            if (result != null)
            {
                result.Description = model.Description;
                result.Name = model.Name;
                _context.SaveChanges();
                return true;
            }

            return false;

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
                IsDeleted = d.IsDeleted
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
    }
}

