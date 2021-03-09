using System;
using System.Windows.Forms;
using ElbayaNPresentation.Presenters.Purchases.Supplier.AllSuppliers;
using Guna.UI2.WinForms;

namespace ElbayaNPresentation.Views.Client.Suppliers
{
    public partial class ucAllSupplier : UserControl, IViewAllSuppleir
    {
        public ucAllSupplier()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new PresenterSupplierData(this);
            Presenter.OnLoadUC();
        }

        private static ucAllSupplier _instance;
        public static ucAllSupplier Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAllSupplier();
                return _instance;
            }
        }

        public DataGridView ActiveObject { get => dgvActiveObjects; set => dgvActiveObjects = value; }
        public DataGridView DeletedObject { get => dgvDeletedObjects; set => dgvDeletedObjects = value; }
        public Guna2TextBox SearchtxtBox { get => txtSearch; set => txtSearch = value; }
        public Guna2Button AddNewObject { get => btnAdd; set => btnAdd = value; }
        public TabControl TabControl { get => tabDGVContainer; set => tabDGVContainer = value; }
        public PresenterSupplierData Presenter { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnAddNewObject();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Presenter.OnTextChnagedtxtSearch();
        }
        private void dgvActiveObjects_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickdgvActiveObject();
        }
        private void dgvDeletedObjects_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickdgvNotActiveObject();

        }
    }
}
