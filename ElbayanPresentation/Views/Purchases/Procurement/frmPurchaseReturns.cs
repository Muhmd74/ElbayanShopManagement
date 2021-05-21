using ElbayaNPresentation.Presenters.Orders.Purchases.PurchaseReturn;
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

namespace ElbayaNPresentation.Views.Purchases
{
    public partial class frmPurchaseReturns : MetroFramework.Forms.MetroForm, IViewPurchaseReturn
    {
        public frmPurchaseReturns()
        {
            InitializeComponent();
            _instance = this;
            dtpOrderReturnDate.Value = DateTime.Now;
            Presenter = new PresenterPurchaseReturn(this);
        }
        private static frmPurchaseReturns _instance;
        public static frmPurchaseReturns Instance { get { if (_instance == null) _instance = new frmPurchaseReturns(); return _instance; } }
        public PresenterPurchaseReturn Presenter { get; set; }
        Label IViewPurchaseReturn.SupplierName { get => lblSupplierName; set => lblSupplierName = value; }
        public Label POSName { get => lblPOSName; set => lblPOSName = value; }
        Label IViewPurchaseReturn.UserName { get => lblUserName; set => lblUserName = value; }
        public RadioButton IsOnlyOneProduct { get => IsOnlyOneProduct; set => IsOnlyOneProduct = value; }
        public NumericUpDown ReturnAmountOfProduct { get => nudReturnAmountOfProduct; set => nudReturnAmountOfProduct = value; }
        public DataGridView OrderProducts { get => dgvOrderProducts; set => dgvOrderProducts = value; }
        public Guna2TextBox SearchText { get => txtSearch; set => txtSearch = value; }
        public Guna2TextBox TotalOrder { get => txtTotalOrder; set => txtTotalOrder = value; }
        public Guna2TextBox OrderDeferred { get => txtOrderDeferred; set => txtOrderDeferred = value; }
        public Guna2TextBox OrderPayment { get => txtOrderPayment; set => txtOrderPayment = value; }
        public Guna2TextBox TotalOrderVAT { get => txtTotalOrderVAT; set => txtTotalOrderVAT = value; }
        public Guna2TextBox CollectedPersonName { get => txtcollectedPersonName; set => txtcollectedPersonName = value; }
        public Guna2TextBox CollectedPersonMobile { get => txtCollectedPersonMobile; set => txtCollectedPersonMobile = value; }
        public Guna2TextBox CollectedPersonJob { get => txtCollectedPersonJob; set => txtCollectedPersonJob = value; }
        public Guna2DateTimePicker ReturndateTime { get => dtpOrderReturnDate; set => dtpOrderReturnDate = value; }
        Guna2Button IViewPurchaseReturn.Close { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guna2Button ReturnAllOrderProduct { get => btnReturnAllOrderProduct; set => btnReturnAllOrderProduct = value; }
        public Guna2Button ReturnSelectedProduct { get => btnReturnProduct; set => btnReturnProduct = value; }
        public Guna2Button ReturnSpicificquantitySelectedProduct { get => btnReturnSpicifiedQuantity; set => btnReturnSpicifiedQuantity = value; }

        private void frmPurchaseReturns_Load(object sender, EventArgs e)
        {
            Presenter.OnLoad();
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
