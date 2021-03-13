using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Employees.Roles.Dtos.Response;
using ElbayanServices.Repository.Employees.Template.Dtos;
using Optics.Utility.Repositories.Members.RoleTemplate.Dtos;

namespace ElbayanServices.Repository.Employees.RoleTemplate
{
    public interface IRoleTemplate
    {
       List<RoleTemplateDto> Get();
       List<TemplateResponseDto> GetByRoleId(Guid roleId);
       List<RoleNamesResponseDto> GetByTemplateId(Guid templateId);
       bool Add(RoleTemplateDto model);
       bool AddTemplateToUser(Guid templateId, Guid employeeId);
       bool UpdateTemplateToUser(RoleTemplateToUserDto model);
       bool Update(RoleTemplateDto model);
       bool Delete(Guid id);
        
        
    }
}