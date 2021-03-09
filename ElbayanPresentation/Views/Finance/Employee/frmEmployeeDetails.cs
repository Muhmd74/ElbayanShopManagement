using ElbayaNPresentation.Presenters.Finance.Employee;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Finance.Employee
{
    public partial class frmEmployeeDetails : Form, IViewEmployee
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
            _instance = this;
        }
        private static frmEmployeeDetails _instance;
        public static frmEmployeeDetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmEmployeeDetails();
                return _instance;
            }
        }

        public PresenterEmployee Presenter { get; set; }
        public Guid ID { get; set; }
        public Guna2TextBox EmployeeName { get => txtEmployeeName; set => EmployeeName = value; }
        public Guna2TextBox Email { get => txtEmployeeEmail; set => txtEmployeeEmail = value; }
        public Guna2TextBox Password { get => txtEmployeePassword; set => txtEmployeePassword = value; }
        public Guna2TextBox Mobile { get => txtEmployeeMobile; set => txtEmployeeMobile = value; }
        public Guna2TextBox Address { get => txtEmployeeAddress; set => txtEmployeeAddress = value; }
        public Guna2TextBox Identity { get => txtEmployeeNationalIdentity; set => txtEmployeeNationalIdentity = value; }
        public Guna2DateTimePicker DateOfBirth { get => dtpEmployeeDateOfBirth; set => dtpEmployeeDateOfBirth = value; }
        public Guna2DateTimePicker IdentityExpirationDate { get => dtpEmployeeIDExpirationDate; set => dtpEmployeeIDExpirationDate = value; }
        public Guna2TextBox PassportNumber { get => txtEmployeePassport; set => txtEmployeePassport = value; }
        public Guna2DateTimePicker PassportExpirationDate { get => dtpPassportExpirationDate; set => dtpPassportExpirationDate = value; }
        public Guna2TextBox ResidenceType { get => txtEmployeeResidenceType; set => txtEmployeeResidenceType = value; }
        public Guna2TextBox Position { get => txtEmployeePosition; set => txtEmployeePosition = value; }
        public CheckBox IsActive { get => cbIsActive; set => cbIsActive = value; }
      
    }
}
