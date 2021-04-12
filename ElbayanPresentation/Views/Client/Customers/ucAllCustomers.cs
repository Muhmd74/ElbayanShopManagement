using System;
using System.Windows.Forms;
using ElbayaNPresentation.Presenters.Clients;
using ElbayaNPresentation.Presenters.Purchases.Supplier.AllSuppliers;
using ElbayanServices.Repository.Clints.Customer;
using Guna.UI2.WinForms;

namespace ElbayaNPresentation.Views.Client.Customers
{
    public partial class ucAllCustomers : UserControl, IViewCustomers
    {
        public ucAllCustomers()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new PresenterCustomers(this);
            Presenter.OnLoadUC();
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

        public Guid ID { get; set; }
        public DataGridView ActiveObject { get => dgvActiveObjects; set => dgvActiveObjects = value; }
        public DataGridView DeletedObject { get => dgvDeletedObjects; set => dgvDeletedObjects = value; }
        public Guna2TextBox SearchTextBox { get => txtSearch; set => txtSearch = value; }
        public Guna2Button AddNewClient { get => btnAdd; set => btnAdd = value; }
        public TabControl TabControl { get => tabDGVContainer; set => tabDGVContainer = value; }
        public PresenterCustomers Presenter { get; set; }
    }
}
