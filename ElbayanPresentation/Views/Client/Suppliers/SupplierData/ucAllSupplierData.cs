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
using ElbayaNPresentation.Presenters.Purchases.Supplier._ِAllSuppliers;

namespace ElbayaNPresentation.Views.Purchases.Suppliers.SupplierData
{
    public partial class ucSupplierData : DevExpress.XtraEditors.XtraUserControl, IViewAllSuppleir
    {
        public ucSupplierData()
        {
            InitializeComponent();
            Presenter = new PresenterSupplierData(this);
            Presenter.OnLoadUC();
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

        public DataGridView ActiveObject { get => dgvActiveObjects; set => dgvActiveObjects = value; }
        public DataGridView DeletedObject { get => dgvDeletedObjects; set => dgvDeletedObjects = value; }
        public Guna2TextBox SearchtxtBox { get => txtSearch; set => txtSearch = value; }
        public Guna2Button AddNewObject { get => btnAdd; set => btnAdd = value; }
        public TabControl TabControl { get => dgvTabContainer; set => dgvTabContainer = value; }
        public PresenterSupplierData Presenter { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnAddNewObject();
        }
    }
}
