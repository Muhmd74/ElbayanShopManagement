using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Authentications.Template.Dtos;

namespace ElbayanServices.Repository.Authentications.Template
{
    public class TemplateService : ITemplate, IDisposable
    {
        private readonly ConnectionOption _context;

        public TemplateService(ConnectionOption context)
        {
            _context = context;

        }

        public static bool UserInRole(Guid employeeId, Guid roleId)
        {
            var context = new ConnectionOption();
            return context.EmployeeRoles.Any(f => f.RoleId == roleId && f.EmployeeId == employeeId);

        }
        public List<TemplateResponseDto> Get()
        {
            return _context.Templates
                     .Select(l => new TemplateResponseDto
                     {
                         Id = l.Id,
                         Name = l.Name
                     })
                     .ToList();

        }

        public TemplateResponseDto Get(Guid id)
        {

            return _context.Templates
                .Select(l => new TemplateResponseDto
                {
                    Id = l.Id,
                    Name = l.Name,
                }).FirstOrDefault(p => p.Id == id);

        }

        public bool Add(TemplateRequestDto model)
        {

            var template = _context.Templates.Add(new ElbayanDatabase.DataClasses.Authentications.Template()
            {
                Name = model.Name,

            });
            _context.SaveChanges();
            return true;
        }

        public bool Update(TemplateRequestDto model)
        {

            var template = _context.Templates.FirstOrDefault(p => p.Id == model.Id);
            if (template != null)
            {
                template.Name = model.Name;
                _context.SaveChanges();
                return true;
            }

            return true;
        }

        public bool DisableOrEnable(Guid id)
        {

            var template = _context.Templates.FirstOrDefault(p => p.Id == id);
            if (template != null)
            {

                template.IsDeleted = !template.IsDeleted;
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