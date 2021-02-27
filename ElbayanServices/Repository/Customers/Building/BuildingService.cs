using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Customers.Building.Dtos;

namespace ElbayanServices.Repository.Customers.Building
{
    public class BuildingService : IBuilding, IDisposable
    {
        private readonly ConnectionOption _context;

        public BuildingService(ConnectionOption context)
        {
            _context = context;
        }

        public bool Create(BuildingDto model)
        {
            _context.Buildings.Add(new ElbayanDatabase.DataClasses.Customers.Sales.Building()
            {
                Address = model.Address,
                Description = model.Description,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber
            });
            _context.SaveChanges();
            return true;
        }

        public bool Update(BuildingDto model)
        {
            var building = _context.Buildings.FirstOrDefault(d => d.Id == model.Id);
            if (building != null)
            {
                building.Description = model.Description;
                building.Address = model.Address;
                building.PhoneNumber = model.PhoneNumber;
                building.Name = model.Name;
                _context.SaveChanges();
                return true;

            }

            return false;
        }

        public BuildingDto GetById(Guid id)
        {
            var building = _context.Buildings.FirstOrDefault(d => d.Id == id);
            if (building != null)
            {
                return new BuildingDto()
                {
                    Description = building.Description,
                    Address = building.Address,
                    Id = building.Id,
                    Name = building.Name,
                    PhoneNumber = building.PhoneNumber
                };
            }

            return null;

        }

        public List<BuildingDto> GetAllBuilding()
        {
            return _context.Buildings.Select(d => new BuildingDto()
            {
                Description = d.Description,
                Address = d.Address,
                Id = d.Id,
                Name = d.Name,
                PhoneNumber = d.PhoneNumber
            }).ToList();
        }

        public bool Delete(Guid id)
        {
            var building = _context.Buildings.FirstOrDefault(d => d.Id == id);
            if (building!=null)
            {
                _context.Buildings.Remove(building);
                return true;
            }

            return false;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
