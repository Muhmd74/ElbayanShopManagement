using ElbayaNPresentation.Views.Finance.Employee;
using ElbayanServices.Repository.Employees.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Finance.Employee
{
    public class PresenterEmployee
    {
        private readonly IViewEmployee _view;
        private readonly EmployeeService employeeService = new EmployeeService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterEmployee(IViewEmployee view)
        {
            _view = view;
        }


        // CRUD:
        // 1. Create:

        public void CreateObject()
        {
            employeeService.CreateEmployee( new ElbayanServices.Repository.Employees.Employees.Dtos.EmployeeDto { 
                Name = _view.EmployeeName.Text,
                Mobile = _view.Mobile.Text,
                DateOfBirth = _view.DateOfBirth.Value,
                Address = _view.Address.Text,
                Email =_view.Email.Text,
                Identity = _view.Identity.Text,
                IsActive = _view.IsActive.Checked,
                IdentityExpirationDate = _view.IdentityExpirationDate.Value,
                PassportNumber = _view.PassportNumber.Text,
                PassportExpirationDate = _view.PassportExpirationDate.Value,
                Password = _view.Password.Text,
                ResidenceType = _view.ResidenceType.Text,
                Position = _view.Position.Text,
                Salary = Convert.ToDecimal(_view.Salary.Text)
            });

            MessageBox.Show("Well DONE, !!!!", "Greetings");
        }

        internal void UpdateObject()
        {
            UpdateObjectById();
            MessageBox.Show("Well DONE !!!!!!!!!!!", "");
        }
        internal void UpdateObjectById()
        {
            employeeService.UpdateEmployee(new ElbayanServices.Repository.Employees.Employees.Dtos.EmployeeDto() 
            {
                Id = ucAllEmployeeData.Instance.ID,
                Name = _view.EmployeeName.Text,
                Mobile = _view.Mobile.Text,
                DateOfBirth = _view.DateOfBirth.Value,
                Address = _view.Address.Text,
                Email = _view.Email.Text,
                Identity = _view.Identity.Text,
                IsActive = _view.IsActive.Checked,
                IdentityExpirationDate = _view.IdentityExpirationDate.Value,
                PassportNumber = _view.PassportNumber.Text,
                PassportExpirationDate = _view.PassportExpirationDate.Value,
                Password = _view.Password.Text,
                ResidenceType = _view.ResidenceType.Text,
                Position = _view.Position.Text,
                Salary = Convert.ToDecimal(_view.Salary.Text)
            });;
        }
        internal void ClearControl()
        {
            _view.EmployeeName.Text = _view.EmployeeName.Text = _view.Password.Text = _view.Mobile.Text = _view.Email.Text = 
                _view.Address.Text = _view.Identity.Text = _view.PassportNumber.Text = _view.Position.Text = _view.Salary.Text = string.Empty;
            _view.DateOfBirth.Value = _view.IdentityExpirationDate.Value = _view.PassportExpirationDate.Value = DateTime.Now;
        }
    }
}
