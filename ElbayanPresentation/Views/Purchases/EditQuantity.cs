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
    public partial class frmEditQuantity : DevExpress.XtraEditors.XtraForm, IViewQuantityEdit
    {
        public frmEditQuantity()
        {
            InitializeComponent();
            _intance = this;
            Presenter = new PresenterQuantityEdit(this);
            txtQuantity.Select();
            Presenter.ClearControls();
            Presenter.OnLoad();

            
        }
        private static frmEditQuantity _intance;
        public static frmEditQuantity Intance { get { if (_intance == null) _intance = new frmEditQuantity(); return _intance; } }

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
        public decimal Vat { get; set; }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateControls.ValidateTextBoxOnlyNumber(sender, e, txtQuantity);
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
            Presenter.PopulateOrderProductUpdatedQuantity();
        }
        private void frmEditQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F10)
            {
                txtQuantity_Leave(null, null);
                this.Close();
                frmProcurementOrder.Intance.Presenter.ClaculateTotalOrderAmount();
            }
        }
    }
}