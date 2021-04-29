using ElbayaNPresentation.Presenters.Clients.Suppliers.SupplierDebit;
using ElbayaNPresentation.Views.Client;
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

namespace ElbayaNPresentation.Views.Purchases.Suppliers
{
    public partial class frmSupplierDebits : MetroFramework.Forms.MetroForm, IViewSupplierDebit
    {
        public frmSupplierDebits()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new PresenterSupplierDebit(this);
            Presenter.OnLoad();
        }
        private static frmSupplierDebits _instance;

        public static frmSupplierDebits Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmSupplierDebits();
                return _instance;
            }
        }
        public PresenterSupplierDebit Presenter { get; set; }
        public ComboBox SupplierList { get => cbxActiveSuppliers; set => cbxActiveSuppliers = value; }
        public Guna2DateTimePicker StartDateToFilterBy { get; set; }
        public Guna2DateTimePicker EndDateToFilterBy { get; set; }
        public Guna2Button Searchbtn { get => btnSearch; set => btnSearch = value; }
        public Guna2Button Printbtn { get => btnPrintStatement; set => btnPrintStatement = value; }
        public DataGridView SuppliersMovementList { get => dgvSearchResult; set => dgvSearchResult = value; }
        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPayDebit.Instance.ShowDialog();
        }
    }

}
