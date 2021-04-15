using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanServices.Repository.Employees.Poses.Dtos;

namespace ElbayanServices.Repository.Employees.Poses
{
    public class PosService : IPos, IDisposable
    {
        private readonly ConnectionOption _context;

        public PosService(ConnectionOption context)
        {
            _context = context;
        }

        public bool Create(PosDto model)
        {
            _context.Poses.Add(new POS()
            {
                Name = model.Name,
                BuildingId = model.BuildingId,
            });
            _context.SaveChanges();
            return true;
        }

        public bool Update(PosDto model)
        {
            var pos = _context.Poses.FirstOrDefault(d => d.Id == model.Id);
            if (pos != null)
            {
                pos.BuildingId = model.BuildingId;
                pos.Name = model.Name;
                _context.SaveChanges();
                return true;

            }

            return false;
        }

        public List<PosDetailsDto> GetAll()
        {
            return _context.Poses.Include(d=>d.Building)
                .Select(d => new PosDetailsDto()
            {
                Id = d.Id,
                Name = d.Name,
                BuildingId = d.BuildingId,
                BuildingName = d.Building.Name
            }).ToList();
        }

        public List<BuildingNameDto> GetBuilding()
        {
            return _context.Buildings.Where(d=>d.IsDeleted==false).Select(d => new BuildingNameDto()
            {
                Id = d.Id,
                Name = d.Name
            }).ToList();
            
        }

        public PosDto GetById(Guid id)
        {
            var pos = _context.Poses.FirstOrDefault(d => d.Id == id);
            if (pos!=null)
            {
                return new PosDto
                {
                    Id = pos.Id,
                    Name = pos.Name,
                    BuildingId = pos.BuildingId,
                };
            }

            return null;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
