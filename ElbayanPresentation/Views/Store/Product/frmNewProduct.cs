using ElbayaNPresentation.Presenters.Store.Product.ProductCard;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Store.Product
{
    public partial class frmNewProduct : MetroFramework.Forms.MetroForm, IViewNewProdcut
    {
        public frmNewProduct()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new ProductPresnter(this); 
            Presenter.OnLoad();
        }

        private static frmNewProduct _instance;
        public static frmNewProduct Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmNewProduct();
                return _instance;
            }
        }

        public Guid ID { get; set; }
        public Guna2TextBox UCP { get => txtUCPNumber; set => txtUCPNumber = value; }
        public Guna2TextBox BarCode { get => txtCBCNumber; set => txtCBCNumber = value; }
        public Guna2TextBox ProudctName { get => txtName; set => txtName = value; }
        public Guna2TextBox PSNumber { get => txtPSNNumber; set => txtPSNNumber = value; }
        public string ImageUrl { get; set; }
        public Guna2TextBox Description { get => txtDescription; set => txtDescription = value; }
        public NumericUpDown PurchaseDefaultPrice { get => nudDefaultPurchasePrice; set => nudDefaultPurchasePrice = value; }
        public NumericUpDown SaleDefaultPrice { get => nudDefaultSalePrice; set => nudDefaultSalePrice = value; }
        public NumericUpDown WholesalePrice { get => nudDefaultWholesalePrice; set => nudDefaultWholesalePrice = value; }
        public bool IsUnitSale { get; set; } = true;
        public Guna2ComboBox SubCategory { get => cbxSubcategory; set => cbxSubcategory = value; }
        public CheckBox IsExpired { get => cbIsExpired; set => cbIsExpired = value; }
        public CheckBox IsDeleted { get => cbIsDeleted; set => cbIsDeleted = value; }
        public Guna2ComboBox LargeUnit { get => cbxLargeUnit; set => cbxLargeUnit = value; }
        public Guna2ComboBox SmallUnit { get => cbxSmallUnit; set => cbxSmallUnit = value; }
        public Guna2TextBox LimitedDemand { get => txtLimitedDemand; set => txtLimitedDemand = value; }
        public Guna2TextBox ProductQuantity { get => txtQuantity; set => txtQuantity = value; }
        public ProductPresnter Presenter {get; set; }
        public NumericUpDown Disccount { get => nudDiscountPercent; set => nudDiscountPercent = value; }
        public NumericUpDown VAT { get => nudVATPercent; set => nudVATPercent = value; }
        public Guna2Button AddObject { get => btnAdd; set => btnAdd = value; }
        public Guna2Button UploadProductPicture { get => btnUploadPicture; set => btnUploadPicture = value; }
        public Guna2Button DeleteOrRestore { get => btnDeleteOrRestore; set => btnDeleteOrRestore = value; }
        public Guna2Button UpdateObject { get => btnUpdate; set => btnUpdate = value; }
        public Guna2PictureBox ProductPicture { get => pbProductImage; set => pbProductImage = value; }
        public Guna2CustomRadioButton LargeUnitIsMainUnit { get => rbLargeUnitIsMainUnit; set => rbLargeUnitIsMainUnit = value; }
        public Guna2CustomRadioButton SmallUnitIsMainUnit { get => rbSmallUnitIsMainUnit; set => rbSmallUnitIsMainUnit = value; }
        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            txtCBCNumber.Text = Presenter.GenerateProductNumber().ToString();
        }
        private void txtUCPNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Read Barcod:
            if (e.KeyChar == 13)
            {
                txtUCPNumber.Text = e.KeyChar.ToString();
            }
        }
        private void cbxLargeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.FillcbxSmallunit();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDeleteOrRestore_Click(object sender, EventArgs e)
        {
            Presenter.OnClickDeletOrRestore();
        }
    }
}