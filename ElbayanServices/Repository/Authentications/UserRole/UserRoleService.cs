using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Employees.Employees;
using ElbayanServices.Repository.Authentications.Roles.Dtos;
using ElbayanServices.Repository.Authentications.Template;
using ElbayanServices.Repository.Authentications.UserRole.Dtos;

namespace ElbayanServices.Repository.Authentications.UserRole
{
    public class UserRoleService : IUserRole, IDisposable
    {
        private readonly ConnectionOption _context;

        public UserRoleService(ConnectionOption context)
        {
            _context = context;
        }

        public List<UserRoleDto> Get()
        {

            return _context.EmployeeRoles.Select(l => new UserRoleDto
            {
                Id = l.Id,
                RoleId = l.RoleId,
                EmployeeId = l.EmployeeId
            }).ToList();

        }

        public List<UserNameDto> GetByRoleId(Guid roleId)
        {

            return _context.EmployeeRoles
                 .Include(p => p.Employee)
                 .Where(p => p.RoleId == roleId)
                 .Select(l => new UserNameDto
                 {
                     Name = l.Employee.Name,
                     Id = l.Id
                 })
                 .ToList();

        }

        public List<RoleNamesResponseDto> GetByEmployee(Guid employeeId)
        {
            return _context.EmployeeRoles
                    .Include(p => p.Role)
                    .Where(p => p.EmployeeId == employeeId)
                    .Select(l => new RoleNamesResponseDto
                    {
                        Name = l.Role.Name,
                        Id = l.Id
                    })
                    .ToList();

        }

        public bool Add(UserRoleDto model)
        {

            if (!TemplateService.UserInRole(model.EmployeeId, model.RoleId))
            {

                var result = _context.EmployeeRoles.Add(new EmployeeRole()
                {
                    RoleId = model.RoleId,
                    EmployeeId = model.EmployeeId
                });
                _context.SaveChanges();
                model.Id = result.Id;
                return true;
            }

            return false;
        }

        public bool Update(UserRoleDto model)
        {
            var result = _context.EmployeeRoles.FirstOrDefault(p => p.Id == model.Id);
            if (result != null)
            {
                result.RoleId = model.RoleId;
                result.EmployeeId = model.EmployeeId;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(Guid id)
        {

            var model = _context.EmployeeRoles.FirstOrDefault(p => p.Id == id);
            if (model != null)
            {
                _context.EmployeeRoles.Remove(model);
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