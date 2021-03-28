using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Authentications.Roles.Dtos;
using ElbayanServices.Repository.Authentications.RoleTemplate.Dtos;
using ElbayanServices.Repository.Authentications.Template.Dtos;

namespace ElbayanServices.Repository.Authentications.RoleTemplate
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