using ElbayaNPresentation.Views.Finance.Employee;
using ElbayanServices.Repository.Employees.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Finance.Employee.ALLEmployee
{
    public class PresenterAllEmployee
    {
        private readonly IViewAllEmployee _view;
        private readonly EmployeeService employeeService = new EmployeeService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterAllEmployee(IViewAllEmployee view)
        {
            _view = view;
        }

        public void OnLoadUc()
        {
            PopulateActiveObject();
            PopulateActiveObject();
        }

        public void PopulateActiveObject() 
        {
            if (employeeService.GetAllEmployee().Any())
            {
                _view.ActiveObject.DataSource = employeeService.GetAllEmployee();
            }
            else
            {
                _view.ActiveObject.DataSource = null;
            }
        }
        public void PopulateNotActiveObject() 
        {
            if (employeeService.GetAllEmployeeNotActive().Any())
            {
                _view.NotActiveObject.DataSource = employeeService.GetAllEmployeeNotActive();
            }
            else
            {
                _view.NotActiveObject.DataSource = null;
            }
        }

        internal void ActiveObjectDGV_DoubleClick()
        {
            _view.ID = new Guid(_view.ActiveObject.CurrentRow.Cells["ActiveObjectID"].Value.ToString());
            GetByID(_view.ID);
            frmEmployeeDetails.Instance.btnUpdateObject.Visible = true;
            frmEmployeeDetails.Instance.ShowDialog();
        }
        internal void GetByID(Guid ID)
        {
            var model = employeeService.GetById(ID);
            frmEmployeeDetails.Instance.EmployeeName.Text = model.Name;
            frmEmployeeDetails.Instance.Address.Text = model.Address;
            frmEmployeeDetails.Instance.DateOfBirth.Value = model.DateOfBirth;
            frmEmployeeDetails.Instance.Email.Text = model.Email;
            frmEmployeeDetails.Instance.Identity.Text = model.Identity;
            frmEmployeeDetails.Instance.Mobile.Text = model.Mobile;
            frmEmployeeDetails.Instance.PassportNumber.Text = model.PassportNumber;
            frmEmployeeDetails.Instance.PassportExpirationDate.Value = model.PassportExpirationDate;
            frmEmployeeDetails.Instance.ResidenceType.Text = model.ResidenceType;
            frmEmployeeDetails.Instance.Position.Text = model.Position;
            frmEmployeeDetails.Instance.Salary.Text = model.Salary.ToString(); ;
        }
    }
}
