using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Purchases.QuantityEditForm;
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

namespace ElbayaNPresentation.Views.Purchases
{
    public partial class frmEditQuantity : MetroFramework.Forms.MetroForm, IViewQuantityEdit
    {
        public frmEditQuantity()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new PresenterQuantityEdit(this);
            txtQuantity.Select();
            Presenter.OnLoad();
        }
        private static frmEditQuantity _instance;
        public static frmEditQuantity Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmEditQuantity();
                return _instance;
            }
        }
        public Guid ID { get; set; }
        public PresenterQuantityEdit Presenter { get; set; }
        public Guna2TextBox Quantity { get => txtQuantity; set => txtQuantity = value; }
        public Guna2TextBox DefaultPrice { get => txtDefaultPrice; set => txtDefaultPrice = value; }
        public Guna2TextBox Subtotal { get => txtSubtotal; set => txtSubtotal = value; }
        public Guna2TextBox Discount { get => txtDiscount; set => txtDiscount = value; }
        public Guna2TextBox TotalProductPrice { get => txtTotalProductPrice; set => txtTotalProductPrice = value; }
        public Guna2TextBox TotalWithVat { get => txtTotalPrice; set => txtTotalPrice = value; }
        public CheckBox IsVatIncluded { get => cbIncludeVAT; set => cbIncludeVAT = value; }
        public Guna2Button SaveQuantityt { get => btnSave; set => btnSave = value; }
        public Label VatValue { get => lblVatValue; set => lblVatValue = value; }
        public Label DiscountValue { get => lblDiscountValue; set => lblDiscountValue = value; }
        public decimal Vat { get; set; }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateControls.ValidateTextBoxOnlyNumber(sender, e, txtQuantity);
            this.txtQuantity.MaxLength = 12;
        }
        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            Presenter.CalulateQuanity();
        }
        private void txtDefaultPrice_Leave(object sender, EventArgs e)
        {
            Presenter.CalulateQuanity();
        }
        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            Presenter.CalulateQuanity();
        }
        private void frmEditQuantity_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Presenter.PopulateOrderProductUpdatedQuantity();
        }
        private void frmEditQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantity_Leave(null, null);
                this.Close();
                frmOrderPurchase.Intance.Presenter.ClaculateTotalOrderAmount();
            }
        }
        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            this.txtQuantity.SelectAll();
        }
        private void txtDefaultPrice_Enter(object sender, EventArgs e)
        {
            this.txtDefaultPrice.SelectAll();
        }
        private void txtDefaultPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateControls.ValidateTextBoxOnlyNumber(sender, e, txtDefaultPrice);
            this.txtDefaultPrice.MaxLength = 9;
        }
        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            this.txtDiscount.SelectAll();
        }
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateControls.ValidateTextBoxOnlyNumber(sender, e, txtDiscount);
            this.txtDiscount.MaxLength = 4;
        }
        private void txtDefaultPrice_Leave_1(object sender, EventArgs e)
        {
            Presenter.CalulateQuanity();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            txtQuantity_Leave(null, null);
            this.Close();
            frmOrderPurchase.Intance.Presenter.ClaculateTotalOrderAmount();
        }
    }
}