using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Employees.Employees.Dtos;

namespace ElbayanServices.Repository.Employees.Employees
{
    public interface IEmployee
    {
        Guid Login(LoginDto model);

        bool CreateEmployee(EmployeeDto model);
        bool UpdateEmployee(EmployeeDto model);
        bool EnableOrDisable(Guid id);
        List<EmployeeNameDto> GetEmployeesName();
        List<EmployeeDto> GetAllEmployee();
        List<EmployeeDto> GetAllEmployeeNotActive();
        EmployeeDto GetById(Guid id);
        bool ResetPassword(Guid employeeId, string newPassword);
        bool ChangePassword(Guid employeeId, string oldPassword, string newPassword);
    }
}
