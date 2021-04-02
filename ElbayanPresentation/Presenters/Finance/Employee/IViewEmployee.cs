using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Finance.Employee
{
    public interface IViewEmployee
    {
        PresenterEmployee Presenter { get; set; }
        Guid ID { get; set; }
        Guna2TextBox EmployeeName { get; set; }
        Guna2TextBox Email { get; set; }
        Guna2TextBox Password { get; set; }
        Guna2TextBox Mobile { get; set; }
        Guna2TextBox UserName { get; set; }
        Guna2TextBox Address { get; set; }
        Guna2TextBox Identity { get; set; }
        Guna2DateTimePicker DateOfBirth { get; set; }
        Guna2DateTimePicker IdentityExpirationDate { get; set; }
        Guna2TextBox PassportNumber { get; set; } // int
        Guna2DateTimePicker PassportExpirationDate { get; set; }
        Guna2TextBox ResidenceType { get; set; }
        Guna2TextBox Position { get; set; }
        Guna2TextBox Salary { get; set; }
        CheckBox IsActive { get; set; }
        Guna2Button AddObject { get; set; }
        Guna2Button UpdateObject { get; set; }

        
    }
}
