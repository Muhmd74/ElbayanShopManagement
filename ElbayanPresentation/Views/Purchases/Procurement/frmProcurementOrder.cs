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
            Presenter.OnLoad();

        }
        private static frmProcurementOrder _intsance;
        public static frmProcurementOrder Intance
        {
            get {
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
        public Guna2TextBox TotalProductInOrder { get => txtTotalProduOrder; set => txtTotalProduOrder = value; }
        public SimpleButton NewSupplier { get => btnAddNewSupplier; set => btnAddNewSupplier = value; }
        public SimpleButton NewProduct { get => btnAddNewProduct; set => btnAddNewProduct = value; }
        public SimpleButton DeleteProductFromOrder { get => btnDeletedProductFromOrder; set => btnDeletedProductFromOrder = value; }
        public Guna2DateTimePicker OrderDate { get => dtpOrderDate; set => dtpOrderDate = value; }
        public Guna2DateTimePicker OrderDeferredDate { get => dtpDefrredDate; set => dtpDefrredDate = value; }
        public System.Windows.Forms.ComboBox Suppliers { get => cbxSupplier; set => cbxSupplier = value; }
        public System.Windows.Forms.ComboBox Products { get => cbxActiveProduct; set => cbxActiveProduct = value; }
        public RadioButton IsDeferred { get => rbDeferredOrder; set => rbDeferredOrder = value; }
        public RadioButton IsCash { get => rbCashOrder; set => rbCashOrder = value; }
        public LabelControl UserNam { get => lblUserName; set => lblUserName = value; }
        public DataGridView OrderProduct { get => dgvOrderProduct; set => dgvOrderProduct = value; }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            Presenter.NewSupplier_OnCLick();
        }
    }
}