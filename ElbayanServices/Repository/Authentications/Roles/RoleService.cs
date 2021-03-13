using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Employees.Employees;
using ElbayanServices.Repository.Authentications.Roles.Dtos;

namespace ElbayanServices.Repository.Authentications.Roles
{
    public class RoleService : IRole, IDisposable
    {
        private readonly ConnectionOption _context;

        public RoleService(ConnectionOption context)
        {
            _context = context;
        }

        public List<RoleResponseDto> Get()
        {
            return _context.Roles
                .Select(l => new RoleResponseDto
                {
                    Description = l.Description,
                    Id = l.Id,
                    Name = l.Name
                })
                .ToList();

        }


        public List<RoleResponseDto> GetAllRoleByUserId(Guid userId)
        {
            return _context.EmployeeRoles
                 .Include(d => d.Role)
                 .Where(d => d.EmployeeId == userId)
                 .Select(d => new RoleResponseDto()
                 {
                     Id = d.Id,
                     Description = d.Role.Description,
                     Name = d.Role.Name
                 }).ToList();

        }

        public List<RoleNamesResponseDto> GetNames()
        {

            return _context.Roles
                 .Select(l => new RoleNamesResponseDto
                 {
                     Id = l.Id,
                     Name = l.Name
                 })
                 .ToList();
        }

        public RoleResponseDto Get(Guid id)
        {
            return _context.Roles
                     .Select(l => new RoleResponseDto
                     {
                         Id = l.Id,
                         Name = l.Name,
                         Description = l.Description
                     }).FirstOrDefault(p => p.Id == id);

        }

        public bool Add(RoleRequestDto model)
        {

            var role = _context.Roles.Add(new Role
            {
                Name = model.Name,
                Description = model.Description
            });
            _context.SaveChanges();
            return true;
        }

        public bool Update(RoleRequestDto model)
        {

            var role = _context.Roles.FirstOrDefault(p => p.Id == model.Id);
            if (role != null)
            {
                role.Description = model.Description;
                role.Name = model.Name;
                _context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool Delete(Guid id)
        {

            var role = _context.Roles.FirstOrDefault(p => p.Id == id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
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