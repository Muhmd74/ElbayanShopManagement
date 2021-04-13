using ElbayaNPresentation.Presenters.Clients;
using ElbayaNPresentation.Presenters.Clients.Customers;
using ElbayaNPresentation.Views.Client.Customers;
using ElbayaNPresentation.Views.Client.Suppliers;
using ElbayaNPresentation.Views.Purchases.Procurement;
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

namespace ElbayaNPresentation.Views.Client
{
    public partial class frmNewCustomer : MetroFramework.Forms.MetroForm, IViewNewCustomer
    {
        
        public frmNewCustomer()
        {
            InitializeComponent();
            Presenter = new PresenterNewCutsomer(this);
            _instance = this;
            btnUpdate.Visible = false;
            cbIsActive.Enabled = false;

            //// Hanle Full screen Issues 
            //System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            //this.MaximizedBounds = Screen.GetWorkingArea(this);
            //this.WindowState = FormWindowState.Normal;

            Presenter.OnLoad();
        }
      
        private static frmNewCustomer _instance;
        public static frmNewCustomer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmNewCustomer();
                return _instance;
            }
        }
        public Guid ID { get; set; }
        public Guna2TextBox RefSupplierNumber { get => txtRefNumber; set => txtRefNumber = value; }
        public Guna2TextBox SuppliersName { get => txtName; set => txtName = value; }
        public Guna2TextBox IdentityNumber { get => txtIDNumber; set => txtIDNumber = value; }
        public Guna2TextBox Mobile { get => txtMobile; set => txtMobile = value; }
        public Guna2TextBox Fax { get => txtFax; set => txtFax = value; }
        public Guna2TextBox Email { get => txtEmail; set => txtEmail = value; }
        public Guna2TextBox FirmName { get => txtFirmName; set => txtFirmName = value; }
        public Guna2TextBox TradeLicense { get => txtTradeLicense; set => txtTradeLicense = value; }
        public Guna2TextBox TaxNumber { get => txtTAXNumber; set => txtTAXNumber = value; }
        public Guna2TextBox FirmPhoneNumber { get => txtFirmPhoneNumber; set => txtFirmPhoneNumber = value; }
        public Guna2TextBox Address { get => txtAddress; set => txtAddress = value; }
        public Guna2TextBox Note { get => txtNote; set => txtNote = value; }
        public CheckBox IsActive { get => cbIsActive; set => cbIsActive = value; }
        public NumericUpDown OpeningBalance { get => nudOpeningBalance; set => nudOpeningBalance = value; }
        public NumericUpDown CurrentBalance { get => nudCurrentBalance; set => nudCurrentBalance = value; }
        public Guna2Button AddNewObject { get => btnAdd; set => btnAdd = value; }
        public Guna2Button UpdateObject { get => btnUpdate; set => btnUpdate = value; }
        public Guna2Button DeleteObject { get; set; }
        public Guna2Button BackToUc { get => btnBackToUc; set => btnBackToUc = value; }
        public PresenterNewCutsomer Presenter { get; set; }
        public CheckBox IsSupplier { get => cbIsSupplier; set => cbIsSupplier = value; }
        public CheckBox IsCustomer { get => cbIsCustomer; set => cbIsCustomer = value; }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnUpdate();
        }
        private void btnBackToUc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbIsActive_Click(object sender, EventArgs e)
        {
            Presenter.OnActiveChekedChanged();
        }
        private void frmNewClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmOrderPurchase.Intance.Presenter.OnLoad();
            ucAllCustomers.Instance.Presenter.OnLoadUC();
            ucAllSupplier.Instance.Presenter.OnLoadUC();
        }
    }
}