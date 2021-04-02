using ElbayaNPresentation.Views.Finance.Employee;
using ElbayanServices.Repository.Employees.Employees;
using ElbayanServices.Repository.Employees.Employees.Dtos;
using ElbayanServices.Repository.Employees.Employees.Validators;
using FluentValidation.Results;
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
        private void ValidateControls(EmployeeDto empl)
        {
            CreateEmployeeValidator validator = new CreateEmployeeValidator();
            ValidationResult results = validator.Validate(empl);
            IList<ValidationFailure> failures = results.Errors;
            if (!results.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "هناك خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

        }
        public void CreateObject()
        {
            var empl = new ElbayanServices.Repository.Employees.Employees.Dtos.EmployeeDto
            {
                Name = _view.EmployeeName.Text,
                Mobile = _view.Mobile.Text,
                DateOfBirth = _view.DateOfBirth.Value,
                Address = _view.Address.Text,
                Email = _view.Email.Text,
                Identity = _view.Identity.Text,
                IsActive = _view.IsActive.Checked,
                PassportNumber = _view.PassportNumber.Text,
                IdentityExpirationDate = _view.IdentityExpirationDate.Value,
                PassportExpirationDate = _view.PassportExpirationDate.Value,
                Password = _view.Password.Text,
                UserName = _view.UserName.Text,
                ResidenceType = _view.ResidenceType.Text,
                Position = _view.Position.Text,
                Salary = Convert.ToDecimal(_view.Salary.Text)
            };
            //ValidateControls(empl);
            employeeService.CreateEmployee(empl);
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
            }); ;
        }
        internal void ClearControl()
        {
            _view.EmployeeName.Text = _view.EmployeeName.Text = _view.Password.Text = _view.Mobile.Text = _view.Email.Text =
                _view.Address.Text = _view.Identity.Text = _view.PassportNumber.Text = _view.Position.Text = _view.Salary.Text = string.Empty;
            _view.DateOfBirth.Value = _view.IdentityExpirationDate.Value = _view.PassportExpirationDate.Value = DateTime.Now;
        }
    }
}
