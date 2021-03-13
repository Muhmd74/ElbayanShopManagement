using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Authentications.Roles.Dtos;
using ElbayanServices.Repository.Authentications.UserRole.Dtos;

namespace ElbayanServices.Repository.Authentications.UserRole
{
    public interface IUserRole
    {
        List<UserRoleDto> Get();
        List<UserNameDto> GetByRoleId(Guid roleId);
        List<RoleNamesResponseDto> GetByEmployee(Guid employeeId);
        bool Add(UserRoleDto model);
        bool Update(UserRoleDto model);
        bool Delete(Guid id);
    }
}