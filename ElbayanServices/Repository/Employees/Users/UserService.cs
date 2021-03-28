using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Common;
using ElbayanServices.Repository.Employees.Users.Dtos;

namespace ElbayanServices.Repository.Employees.Users
{
    public class UserService : IDisposable, IUser
    {
        private readonly ConnectionOption _context;

        public UserService(ConnectionOption context)
        {
            _context = context;
        }
        public bool CreateUser(UserDto model)
        {
            var emp = _context.Employees.FirstOrDefault(d => d.Id == model.EmployeeId);
            var user = _context.Users.Add(new ElbayanDatabase.DataClasses.Employees.Employees.Users()
            {
                EmployeeId = model.EmployeeId,
                Password = emp.Password,
                UserName = emp.UserName
            });
            _context.SaveChanges();
            return true;
        }

        public bool Update(UserDto model)
        {
            return false;

        }


        public List<GetAllUserDto> GetAllUser()
        {
            return _context.Users
                .Include(d => d.Employee)
                .Where(d => d.Employee.IsActive)
                .Select(d => new GetAllUserDto
                {
                    Name = d.Employee.Name,
                    Mobile = d.Employee.Mobile,
                    UserName = d.UserName,
                    Password = d.Password.ToDecrypt(),
                    Id = d.EmployeeId
                }).ToList();
        }

        public GetAllUserDto GetUserById(Guid userId)
        {
            var emp = _context.Users
                .Include(d=>d.Employee)
                .FirstOrDefault(d => d.Id == userId);
            if (emp != null)
            {
                return new GetAllUserDto
                {
                    Name = emp.Employee.Name,
                    Mobile = emp.Employee.Mobile,
                    UserName = emp.UserName,
                    Password = emp.Password.ToDecrypt(),
                    Id = emp.EmployeeId
                };
            }

            return null;

        }

        public bool IsDelete(Guid userId)
        {
            var emp = _context.Users.FirstOrDefault(d => d.Id == userId);
            emp.IsDeleted =! emp.IsDeleted;
            _context.SaveChanges();
            return true;

        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
