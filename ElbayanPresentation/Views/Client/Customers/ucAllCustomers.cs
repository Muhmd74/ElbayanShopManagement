using System;
using System.Windows.Forms;
using ElbayaNPresentation.Presenters.Purchases.Supplier.AllSuppliers;
using ElbayanServices.Repository.Clints.Customer;
using Guna.UI2.WinForms;

namespace ElbayaNPresentation.Views.Client.Customers
{
    public partial class ucAllCustomers : UserControl, IViewAllSuppleir
    {
        public ucAllCustomers()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new PresenterSupplierData(this);
            //Presenter.OnLoadUC();
            CustomerService service = new CustomerService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
            dgvActiveObjects.DataSource = service.GetAllCustomer();
        }

        private static ucAllCustomers _instance;
        public static ucAllCustomers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAllCustomers();
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

        private void tabDGVContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.OnSelectedIndexChanged_TabControl();
        }
    }
}
