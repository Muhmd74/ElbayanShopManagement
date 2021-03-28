using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Authentications.Roles.Dtos;

namespace ElbayanServices.Repository.Authentications.Roles
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