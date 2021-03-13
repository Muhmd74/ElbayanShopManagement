using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Employees.Roles.Dtos.Request;
using ElbayanServices.Repository.Employees.Roles.Dtos.Response;

namespace ElbayanServices.Repository.Employees.Roles
{
    public interface IRole
    {
      List<RoleResponseDto> Get();
      List<RoleResponseDto> GetAllRoleByUserId(Guid userId);
      List<RoleNamesResponseDto> GetNames();
      RoleResponseDto Get(Guid id);
      bool Add(RoleRequestDto model);
      bool Update(RoleRequestDto model);
      bool Delete(Guid id);

    }
}