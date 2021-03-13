using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Employees.Roles.Dtos.Response;
using ElbayanServices.Repository.Employees.UserRole.Dtos;
using Optics.Utility.Repositories.Members.UserRole.Dtos;

namespace ElbayanServices.Repository.Employees.UserRole
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