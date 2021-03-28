using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Employees.Users.Dtos;

namespace ElbayanServices.Repository.Employees.Users
{
    public interface IUser
    {
        bool CreateUser(UserDto model);
        bool Update(UserDto model);
        List<GetAllUserDto> GetAllUser();
        GetAllUserDto GetUserById(Guid userId);
        bool IsDelete(Guid userId);

    }
}
