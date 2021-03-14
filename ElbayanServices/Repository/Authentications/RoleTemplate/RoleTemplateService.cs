using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Authentications;
using ElbayanDatabase.DataClasses.Employees.Employees;
using ElbayanServices.Repository.Authentications.Roles.Dtos;
using ElbayanServices.Repository.Authentications.RoleTemplate.Dtos;
using ElbayanServices.Repository.Authentications.Template;
using ElbayanServices.Repository.Authentications.Template.Dtos;

namespace ElbayanServices.Repository.Authentications.RoleTemplate
{
    public class RoleTemplateService : IRoleTemplate, IDisposable
    {
        private readonly ConnectionOption _context;

        public RoleTemplateService(ConnectionOption context)
        {
            _context = context;
        }

        public List<RoleTemplateDto> Get()
        {
            return _context.RolesTemplates.Select(l => new RoleTemplateDto
            {
                Id = l.Id,
                RoleId = l.RoleId,
                TemplateId = l.TemplateId
            }).ToList();
        }

        public List<TemplateResponseDto> GetByRoleId(Guid roleId)
        {

            return _context.RolesTemplates
                 .Include(p => p.Template)
                 .Where(p => p.RoleId == roleId)
                 .Select(l => new TemplateResponseDto
                 {
                     Name = l.Template.Name,
                     Id = l.Id
                 })
                 .ToList();

        }

        public List<RoleNamesResponseDto> GetByTemplateId(Guid templateId)
        {
            return _context.RolesTemplates
                     .Include(p => p.Template)
                     .Where(p => p.TemplateId == templateId)
                     .Select(l => new RoleNamesResponseDto
                     {
                         Name = l.Template.Name,
                         Id = l.Id
                     })
                     .ToList();
        }


        public bool Add(RoleTemplateDto model)
        {

            var result = _context.RolesTemplates.Add(new ElbayanDatabase.DataClasses.Authentications.RoleTemplate
            {
                RoleId = model.RoleId,
                TemplateId = model.TemplateId
            });
            _context.SaveChanges();
            return true;
        }

        public bool AddTemplateToUser(Guid templateId, Guid employeeId)
        {

            var rolesTemplates = _context.RolesTemplates
                .Where(d => d.TemplateId == templateId)
                .ToList();
            var user = _context.Employees.FirstOrDefault(d => d.Id == employeeId);
            foreach (var rolesTemplate in rolesTemplates)
            {
                if (!TemplateService.UserInRole(employeeId, rolesTemplate.RoleId))
                {
                    _context.EmployeeRoles.Add(new EmployeeRole()
                    {
                        RoleId = rolesTemplate.RoleId,
                        EmployeeId = employeeId
                    });
                    _context.SaveChanges();


                }
            }

            return true;
        }

        public bool UpdateTemplateToUser(RoleTemplateToUserDto model)
        {


            var roles = _context.EmployeeRoles
                .Where(d => d.EmployeeId == model.EmployeeId).ToList();
            _context.EmployeeRoles.RemoveRange(roles);
            _context.SaveChanges();
            foreach (var role in model.Roles)
            {
                if (!TemplateService.UserInRole(model.EmployeeId, role.RoleId))
                {
                    _context.EmployeeRoles.Add(new EmployeeRole()
                    {
                        RoleId = role.RoleId,
                        EmployeeId = model.EmployeeId
                    });


                }
            }
            _context.SaveChanges();
            return true;
        }

        public bool Update(RoleTemplateDto model)
        {
            var result = _context.RolesTemplates.FirstOrDefault(p => p.Id == model.Id);
            if (result != null)
            {
                result.RoleId = model.RoleId;
                result.TemplateId = model.TemplateId;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(Guid id)
        {

            var model = _context.RolesTemplates.FirstOrDefault(p => p.Id == id);
            if (model != null)
            {
                _context.RolesTemplates.Remove(model);
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