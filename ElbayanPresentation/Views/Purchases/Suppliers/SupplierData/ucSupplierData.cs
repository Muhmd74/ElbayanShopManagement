using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.Purchases.Suppliers.SuplliersData;
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

namespace ElbayaNPresentation.Views.Purchases.Suppliers.SupplierData
{
    public partial class ucSupplierData : DevExpress.XtraEditors.XtraUserControl, IViewSuppleirData
    {
        public ucSupplierData()
        {
            InitializeComponent();
            Presenter = new PresenterSupplierData(this);
        }
        private static ucSupplierData _instance;
        public static ucSupplierData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSupplierData();
                return _instance;
            }
        }

        public Guna2TextBox SuppliersName { get => txtName; set => txtName = value; }
        public Guna2TextBox SuppleirIdNumber { get => txtSupplierNumber; set => txtSupplierNumber = value; }
        public Guna2TextBox FirmName { get => txtFirmName; set => txtFirmName = value; }
        public Guna2TextBox Address { get => txtAddress; set => txtAddress = value; }
        public Guna2TextBox CommercialRegister { get => txtTradeLicnse; set => txtTradeLicnse = value; }
        public Guna2TextBox SupplierNumber { get => txtSupplierNumber; set => txtSupplierNumber = value; }
        public Guna2TextBox Description { get => txtDescription; set => txtDescription = value; }
        public Guna2ComboBox CustomerType { get; set; }
        public Guna2TextBox Mobile { get => txtPhoneNumber; set => txtPhoneNumber = value; }
        public Guna2TextBox TaxNumber { get => txtTAXNumber; set => txtTAXNumber = value; }
        public Guna2TextBox SearchtxtBox { get => txtSearch; set => txtSearch = value; }
        public NumericUpDown OpeningBalance { get => nudSupplierBalance; set => nudSupplierBalance = value; }
        public DataGridView ActiveObjetc { get => dgvActiveObjects; set => dgvActiveObjects = value; }
        public DataGridView DeletedObject { get => dgvDeletedObjects; set => dgvDeletedObjects = value; }
        public PresenterSupplierData Presenter { get; set; }
        public Guna2Button btnUpdateObject { get => btnUpdate; set => btnUpdate = value; }
        public Guna2Button btnDeleteObject { get => btnDeleteByOne; set => btnDeleteByOne = value; }
        public TabControl tabControl { get => dgvTabContainer; set => dgvTabContainer = value; }
        public Guna2Button btnAddNewObject { get => btnAdd; set => btnAdd = value; }
    }
}
