//using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ElbayaNPresentation.Presenters.Purchases.ProcurementOrder;
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

namespace ElbayaNPresentation.Views.Purchases.Procurement
{
    public partial class frmOrderPurchase : MetroFramework.Forms.MetroForm, IViewProcurementOrder
    {
        public frmOrderPurchase()
        {
            InitializeComponent();
            _intsance = this;
            Presenter = new PresenterProcurementOrder(this);
            Presenter.OnLoad();
            txtProductBarcode.Select();

        }
        private static frmOrderPurchase _intsance;
        public static frmOrderPurchase Intance
        {
            get
            {
                if (_intsance == null)
                    _intsance = new frmOrderPurchase();
                return _intsance;
            }
        }
        public Guid ID { get; set; }
        public PresenterProcurementOrder Presenter { get; set; }
        public Guna2TextBox OrderNumber { get => txtOrderNumber; set => txtOrderNumber = value; }
        public Guna2TextBox BareCode { get => txtProductBarcode; set => txtProductBarcode = value; }
        public Guna2TextBox TotalOrderWithoutDiscount { get => txtTotalOrderWithoutDiscount; set => txtTotalOrderWithoutDiscount = value; }
        public Guna2TextBox TotalOrderDiscount { get => txtTotalorderDiscountValue; set => txtTotalorderDiscountValue = value; }
        public Guna2TextBox TotalOrderWithDiscount { get => txtOrderSubtotal; set => txtTotalorderDiscountValue = value; }
        public Guna2TextBox TotalOrderWithoutVAT { get => txtTotalOrderWithoutVAT; set => txtTotalOrderWithoutVAT = value; }
        public Guna2TextBox TotalOrderVAT { get => txtOrderVatValue; set => txtOrderVatValue = value; }
        public Guna2TextBox Paid { get => txtPaid; set => txtPaid = value; }
        public Guna2TextBox Deferred { get => txtDeferred; set => txtDeferred = value; }
        public Guna2TextBox SupplierMobile { get => txtSupplierMobile; set => txtSupplierMobile = value; }
        public Guna2Button NewSupplier { get => btnAddNewSupplier; set => btnAddNewSupplier = value; }
        public Guna2Button AddNewProductDGV { get => btnAddNewProductDGV; set => btnAddNewProductDGV = value; }
        public Guna2Button DeleteProductFromOrder { get => btnDeletedProductFromOrder; set => btnDeletedProductFromOrder = value; }
        public Guna2Button UpdateProudctQuantity { get => btnUpdateProudctQuantity; set => btnUpdateProudctQuantity = value; }
        public Guna2Button SaveOrder { get => btnSaveOrder; set => btnSaveOrder = value; }
        public Guna2Button PrintOrder { get => btnPrintOrder; set => btnPrintOrder = value; }
        public Guna2Button NewOrder { get => btnNewOrder; set => btnNewOrder = value; }
        public Guna2Button BackTo { get => btnBackTo; set => btnBackTo = value; }
        public Guna2DateTimePicker OrderDate { get => dtpOrderDate; set => dtpOrderDate = value; }
        public Guna2DateTimePicker OrderDeferredDate { get => dtpDefrredDate; set => dtpDefrredDate = value; }
        public ComboBox Suppliers { get => cbxSupplier; set => cbxSupplier = value; }
        public ComboBox Products { get => cbxActiveProduct; set => cbxActiveProduct = value; }
        public CheckBox IsDeferred { get => cbIsDeferred; set => cbIsDeferred = value; }
        public Guna2TextBox UserName { get => txtUserName; set => txtUserName = value; }
        public DataGridView OrderProduct { get => dgvOrderProduct; set => dgvOrderProduct = value; }
        public int RowIndex { get; set; }

        // Supplier Populate
        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            Presenter.NewSupplier_OnCLick();
        }
        private void cbxSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Presenter.OnSelectedValueChanged_SupplierMobile();
        }
        private void cbxSupplier_Leave(object sender, EventArgs e)
        {
            if(this.cbxSupplier.Text != string.Empty)
            {
                if (this.cbxSupplier.SelectedIndex == -1)
                {
                    MessageBox.Show("يجب اختيار اسم مورد صحيح");
                    this.cbxSupplier.SelectAll();
                    this.cbxSupplier.Select();
                    return;
                }
            }
            
        }
        // Product Populate
        private void txtProductBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F1)
            {
                Presenter.AddProductToDGV();
            }
        }
        private void btnAddNewProductDGV_Click(object sender, EventArgs e)
        {
            Presenter.AddProductToDGVbtn();
        }
        private void btnDeletedProductFromOrder_Click(object sender, EventArgs e)
        {
            Presenter.DeleteFromDGV();
        }
        private void frmOrderPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                Presenter.CreateSupplierOrder();
            }
            if (e.KeyCode == Keys.F11)
            {
                if (dgvOrderProduct.Rows.Count >= 1)
                {
                    if (dgvOrderProduct.SelectedRows.Count > 0)
                    {
                        //RowIndex = dgvOrderProduct.SelectedRows[0].Index;
                        Presenter.PopulateQualityEdit();
                        frmEditQuantity.Instance.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("لا بد من تحديد صف كامل للتعديل عليه");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("لا بد من إضافة منتجات أولا للفاتورة");
                    return;
                }
            }
            if (e.KeyCode == Keys.F2)
            {
                Presenter.AddProductToDGVbtn();
            }
        }
        private void btnUpdateProudctQuantity_Click(object sender, EventArgs e)
        {
            if (dgvOrderProduct.Rows.Count >= 1)
            {
                if (dgvOrderProduct.SelectedRows.Count > 0)
                {
                    Presenter.PopulateQualityEdit();
                    frmEditQuantity.Instance.ShowDialog();
                }
                else
                {
                    MessageBox.Show("لا بد من تحديد صف كامل للتعديل عليه");
                    return;
                }

            }
            else
            {
                MessageBox.Show("لا بد من إضافة منتجات أولا للفاتورة");
                return;
            }
        }
        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            Presenter.ClaculateTotalOrderAmount();
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            Presenter.CreateSupplierOrder();
        }
        private void btnBackTo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Presenter.ClearControl();
        }
        private void cbxActiveProduct_Leave(object sender, EventArgs e)
        {
            if (this.cbxActiveProduct.Text != string.Empty)
            {
                if (this.cbxActiveProduct.SelectedIndex == -1)
                {
                    MessageBox.Show("يجب اختيار اسم منتج صحيح");
                    this.cbxActiveProduct.SelectAll();
                    this.cbxActiveProduct.Select();
                    return;
                }
            }
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            //ReportPrintTool printTools = new ReportPrintTool(Presenter.PrintReport());
            //printTools.ShowPreview();
            Presenter.PrintReport();
        }
    }
}
