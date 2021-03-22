using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Employees.Employees;
using ElbayanServices.Common;
using ElbayanServices.Repository.Employees.Employees.Dtos;

namespace ElbayanServices.Repository.Employees.Employees
{
   public class EmployeeService : IEmployee , IDisposable
   {
       private readonly ConnectionOption _context;

       public EmployeeService(ConnectionOption context)
       {
           _context = context;
       }

       public Guid Login(LoginDto model)
       {
           var user = _context.Employees.FirstOrDefault(
               d => d.Mobile == model.Mobile && d.Password.ToDecrypt() == model.Password);
           return user.Id;
       }
        public bool CreateEmployee(EmployeeDto model)
       {
           var employee = _context.Employees.Add(new Employee()
           {
               Address = model.Address,
               DateOfBirth = model.DateOfBirth.ToUniversalTime(),
               Email = model.Email,
               Identity = model.Identity,
               IsActive = true,
               Mobile = model.Mobile,
               Name = model.Name,
               IdentityExpirationDate = model.IdentityExpirationDate,
               PassportExpirationDate = model.PassportExpirationDate,
               PassportNumber = model.PassportNumber,
               Password = model.Password.ToEncrypt(),
               ResidenceType = model.ResidenceType,
               Position = model.Position,
               Salary = model.Salary
           });
           _context.SaveChanges();
           return true;
       }

        public bool UpdateEmployee(EmployeeDto model)
        {
            var employee = _context.Employees.FirstOrDefault(d => d.Id == model.Id);
            if (employee!=null)
            {
                employee.Address = model.Address;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Identity = model.Identity;
                employee.IdentityExpirationDate = model.IdentityExpirationDate;
                employee.Mobile = model.Mobile;
                employee.Name = model.Name;
                employee.ResidenceType = model.ResidenceType;
                employee.Position = model.Position;
                employee.Salary = model.Salary;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool EnableOrDisable(Guid id)
        {
            var model = _context.Employees.FirstOrDefault(d => d.Id == id);
            if (model!=null)
            {
                model.IsActive = !model.IsActive;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<EmployeeNameDto> GetEmployeesName()
        {
            return _context.Employees.Where(d => d.IsActive)
                .Select(d => new EmployeeNameDto()
                {
                    EmployeeId = d.Id,
                    EmployeeName = d.Name
                }).ToList();
        }

        public List<EmployeeDto> GetAllEmployee()
        {
            return _context.Employees.Where(d => d.IsActive != false)
                .Select(d => new EmployeeDto()
                {
                    Address = d.Address,
                    DateOfBirth = d.DateOfBirth,
                    Email = d.Email,
                    Identity = d.Identity,
                    IdentityExpirationDate = d.IdentityExpirationDate,
                    Mobile = d.Mobile,
                    PassportNumber = d.PassportNumber,
                    PassportExpirationDate = d.PassportExpirationDate,
                    ResidenceType = d.ResidenceType,
                    Name = d.Name,
                    Id = d.Id,
                    Position = d.Position,
                    Salary = d.Salary
                }).ToList();
        }
        public List<EmployeeDto> GetAllEmployeeNotActive()
        {
            return _context.Employees.Where(d => d.IsActive==false)
                .Select(d => new EmployeeDto()
                {
                   Address = d.Address,
                   DateOfBirth = d.DateOfBirth.ToUniversalTime(),
                   Email = d.Email,
                   Identity = d.Identity,
                   IdentityExpirationDate = d.IdentityExpirationDate,
                   Mobile = d.Mobile,
                   PassportNumber = d.PassportNumber,
                   PassportExpirationDate = d.PassportExpirationDate,
                   ResidenceType = d.ResidenceType,
                   Name = d.Name,
                   Id = d.Id,
                   Position = d.Position,
                   Salary = d.Salary

                }).ToList();
        }

        public EmployeeDto GetById(Guid id)
        {
            var employee = _context.Employees.FirstOrDefault(d => d.Id == id);
            if (employee != null)
            {
                return new EmployeeDto()
                {
                    Address = employee.Address,
                    DateOfBirth = employee.DateOfBirth.ToUniversalTime(),
                    Email = employee.Email,
                    Identity = employee.Identity,
                    IdentityExpirationDate = employee.IdentityExpirationDate,
                    Mobile = employee.Mobile,
                    PassportNumber = employee.PassportNumber,
                    PassportExpirationDate = employee.PassportExpirationDate,
                    ResidenceType = employee.ResidenceType,
                    Name = employee.Name,
                    Id = employee.Id,
                    Position = employee.Position,
                    Salary = employee.Salary

                };
            }

            return null;
        }

        public bool ChangePassword(Guid employeeId, string oldPassword, string newPassword)
        {
            var oldPass = oldPassword.ToEncrypt();
            var newPass = newPassword.ToEncrypt();
            var mode = _context.Employees.FirstOrDefault(d => d.Id ==employeeId);
            if (mode != null)
            {
                if (mode.Password==oldPass)
                {
                    mode.Password = newPass;
                    _context.SaveChanges();
                    return true;
                }
            }

            return false;
        }


        public bool ResetPassword(Guid employeeId, string newPassword)
        {
            var model = _context.Employees.FirstOrDefault(d => d.Id == employeeId);
            if (model != null)
            {
                model.Password = newPassword.ToEncrypt();
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
