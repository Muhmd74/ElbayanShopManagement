using DevExpress.XtraEditors;
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
    public partial class frmProcurementOrder : DevExpress.XtraEditors.XtraForm, IViewProcurementOrder
    {
        public frmProcurementOrder()
        {
            InitializeComponent();
            _intsance = this;
            Presenter = new PresenterProcurementOrder(this);
        }
        private static frmProcurementOrder _intsance;
        public static frmProcurementOrder Intance
        {
            get
            {
                if (_intsance == null)
                    _intsance = new frmProcurementOrder();
                return _intsance;
            }
        }

        public Guid ID { get; set; }
        public PresenterProcurementOrder Presenter { get; set; }
        public Guna2TextBox OrderNumber { get => txtOrderNumber; set => txtOrderNumber = value; }
        public Guna2TextBox BareCode { get => txtProductBarcode; set => txtProductBarcode = value; }
        public Guna2TextBox TotalOrder { get => txtTotalOrder; set => txtTotalOrder = value; }
        public Guna2TextBox ItemCounts { get => txtItemCounts; set => txtItemCounts = value; }
        public SimpleButton NewSupplier { get => btnAddNewSupplier; set => btnAddNewSupplier = value; }
        public SimpleButton NewProduct { get => btnAddNewProduct; set => btnAddNewProduct = value; }
        public SimpleButton DeleteProductFromOrder { get => btnDeletedProductFromOrder; set => btnDeletedProductFromOrder = value; }
        public Guna2DateTimePicker OrderDate { get => dtpOrderDate; set => dtpOrderDate = value; }
        public Guna2DateTimePicker OrderDeferredDate { get => dtpDefrredDate; set => dtpDefrredDate = value; }
        public System.Windows.Forms.ComboBox Suppliers { get => cbxSupplier; set => cbxSupplier = value; }
        public System.Windows.Forms.ComboBox Products { get => cbxActiveProduct; set => cbxActiveProduct = value; }
        public RadioButton IsDeferred { get => rbDeferredOrder; set => rbDeferredOrder = value; }
        public RadioButton IsCash { get => rbCashOrder; set => rbCashOrder = value; }
        public LabelControl UserName { get => lblUserName; set => lblUserName = value; }
        public DataGridView OrderProduct { get => dgvOrderProduct; set => dgvOrderProduct = value; }
        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            Presenter.NewSupplier_OnCLick();
        }
        private void txtProductBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F1)
            {
                Presenter.AddProductToDGV();
            }
        }
        private void rbDeferredOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeferredOrder.Checked)
            {
                dtpDefrredDate.Visible = true;
                lblDeferredDate.Visible = true;
            }
            else
            {
                dtpDefrredDate.Visible = false;
                lblDeferredDate.Visible = false;
            }
        }
        private void frmProcurementOrder_Load(object sender, EventArgs e)
        {
            Presenter.OnLoad();
        }
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            Presenter.AddProductToDGVbtn();
        }
        private void cbxActiveProduct_Validating(object sender, CancelEventArgs e)
        {
            if (this.cbxActiveProduct.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار اسم منتج صحيح");
                return;
            }
        }
        private void cbxSupplier_Validating(object sender, CancelEventArgs e)
        {
            if (this.cbxSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("يجب إختيار اسم مورد صحيح");
                return;
            }
        }
        private void cbxActiveProduct_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F2)
            //{
            //    Presenter.AddProductToDGVbtn();
            //}
        }
        private void btnDeletedProductFromOrder_Click(object sender, EventArgs e)
        {
            Presenter.DeleteFromDGV();
        }
        private void txtProductBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar == 13)
            //{
            //    Presenter.AddProductToDGV();
            //}
        }
        private void frmProcurementOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                if (dgvOrderProduct.Rows.Count >= 1)
                {
                    Presenter.CreateSupplierOrder();
                    //frmEditQuantity.Intance.ShowDialog();
                }
                else
                {
                    MessageBox.Show("لا بد من إضافة منتجات أولا للفاتورة");
                    return;
                }

            }  
            if (e.KeyCode == Keys.F11)
            {
                if (dgvOrderProduct.Rows.Count >= 1)
                {
                    Presenter.PopulateQualityEdit();
                    frmEditQuantity.Intance.ShowDialog();
                }
                else
                {
                    MessageBox.Show("لا بد من إضافة منتجات أولا للفاتورة");
                    return;
                }

            }
        }

        private void dgvOrderProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProcurementOrder_KeyDown(null, null);
        }
    }
}