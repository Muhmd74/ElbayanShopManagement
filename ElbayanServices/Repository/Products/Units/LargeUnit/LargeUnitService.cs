using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;

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

        public bool Update(LargeUnitDto model)
        {
            var result = _context.LargeUnits.FirstOrDefault(d => d.Id == model.Id);
            if (result!=null)
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
            var model = _context.LargeUnits.Select(d => new LargeUnitDto()
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
