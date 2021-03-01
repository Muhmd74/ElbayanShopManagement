using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.Store.Product.ProductCard;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Store.Product
{
    public partial class ucNewProductCard : DevExpress.XtraEditors.XtraUserControl, IViewProdct
    {
        public ucNewProductCard()
        {
            InitializeComponent();
            
            Presenter = new ProductPresnter(this);

            _instance = this;

            txtUCPNumber.Focus();

            // hide Unmeric up down Arrows:
            nudDefaultPurchasePrice.Controls[0].Visible = false;
            nudDefaultSalePrice.Controls[0].Visible = false;
            nudDefaultWholesalePrice.Controls[0].Visible = false;
            nudDiscountPercent.Controls[0].Visible = false;
            nudVATPercent.Controls[0].Visible = false;

            PopulatecbxSubcategory();
            PopulatecbxLargeUnit();
        }

        // Apply singlton pattern for form Instance
        private static ucNewProductCard _instance;
        public static ucNewProductCard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucNewProductCard();
                return _instance;
            }
        }

        public int UCP { get => Convert.ToInt32(txtUCPNumber.Text); set => Convert.ToInt32(txtUCPNumber.Text); }
        public int BarCode { get => Convert.ToInt32(txtCBCNumber.Text); set => Convert.ToInt32(txtCBCNumber.Text); }
        public string ImageUrl { get; set; }
        public string ProudctName { get => txtName.Text; set => txtName.Text = value; }
        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public decimal PurchaseDefaultPrice { get => nudDefaultPurchasePrice.Value; set => nudDefaultPurchasePrice.Value = value; }
        public decimal SaleDefaultPrice { get => nudDefaultSalePrice.Value; set => nudDefaultSalePrice.Value = value; }
        public decimal WholesalePrice { get => nudDefaultWholesalePrice.Value; set => nudDefaultWholesalePrice.Value = value; }
        public bool IsUnitSale { get; set; } = true;
        public Guid SubCategoryId { get => new Guid(cbxSubcategory.SelectedValue.ToString()); set => cbxSubcategory.SelectedValue = value; }
        public SubCategoryDto SubCategory { get; set; }
        public bool IsExpired { get => rbIsExpiredProduct.Checked; set => rbIsExpiredProduct.Checked = value; }
        public DateTime ExpireDateTime { get; set; }
        public Guid LargeUnitId { get => new Guid (cbxLargeUnit.SelectedValue.ToString()); set => cbxLargeUnit.SelectedValue = value; }
        public LargeUnitNameDto LargeUnit { get; set; }
        public List<LargeUnitNameDto> LargeUnits { get; set; }
        public Guid SmallUnitId { get; set; }
        public SmallUnitNameDto SmallUnit { get; set; }
        public List<SmallUnitNameDto> smallUnits { get; set; }
        public int LimitedDemand { get => Convert.ToInt32(txtLimitedDemand.Text); set => Convert.ToInt32(txtLimitedDemand.Text); }
        public ProductPresnter Presenter { private get; set; }
        public List<SubCategoryDto> SubCategories { get; set; }
        public int Disccount { get => (Int32) nudDiscountPercent.Value; set => nudDiscountPercent.Value = value; }
        public int VAT { get => (Int32) nudVATPercent.Value; set => nudVATPercent.Value = value; }


        // Handle Picture Uplode
        private void btnUploadPicture_Click(object sender, EventArgs e)
        {

            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "ملفات الصور (*.jpg; *.jpeg; *.gif; *.png; *.bmp;) | *.jpg; *.jpeg; *.gif; *.png; *.bmp;";
            if (image.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(image.FileName))
            {
                pbProductImage.Image = new Bitmap(image.FileName);
                ImageUrl = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\ProductImage\", Path.GetFileName(image.FileName));
                if (File.Exists(ImageUrl))
                {
                    File.Delete(ImageUrl);
                }
                //File.Move(@"c:\test\SomeFile.txt", @"c:\test\Test\SomeFile.txt");
                File.Copy(image.FileName, ImageUrl);
            }
            
        }

        // Populate Commbo boxs.
        private void PopulatecbxSubcategory()
        {
            cbxSubcategory.DataSource = Presenter.FillcbxSubcategory();
            cbxSubcategory.DisplayMember = "Name";
            cbxSubcategory.ValueMember = "Id";
            cbxSubcategory.SelectedValue = "Id";
        }
        private void PopulatecbxLargeUnit()
        {
            cbxLargeUnit.DataSource = Presenter.FillcbxLargeUnit();
            cbxLargeUnit.DisplayMember = "Name";
            cbxLargeUnit.ValueMember = "LargeUnitId";
            //cbxLargeUnit.SelectedValue = "LargeUnitId";
        }
       
        
        private void cbxLargeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLargeUnit.SelectedValue != null)
            {
                Guid LargeUnitId = new Guid(cbxLargeUnit.SelectedValue.ToString());
                cbxSmallUnit.DataSource = Presenter.FillcbxSmallunit(LargeUnitId);
                cbxSmallUnit.DisplayMember = "Name";
                cbxSmallUnit.ValueMember = "SmallUnitId";
                cbxSmallUnit.SelectedValue = "SmallUnitId";
            }
            else
            {
                cbxSmallUnit.DataSource = null;
            }

        }

        // Validate text box for only numbers
        public void onlynumwithsinglepoint(object sender, KeyPressEventArgs e, Guna2TextBox textBox)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
            
        }
              
        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            txtCBCNumber.Text = Presenter.GenerateProductNumber().ToString();
        }

        private void txtLimitedDemand_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumwithsinglepoint(sender, e, txtLimitedDemand);
        }

        private void txtUCPNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumwithsinglepoint(sender, e, txtUCPNumber);
            if (e.KeyChar == 13)
            {
                txtUCPNumber.Text = e.KeyChar.ToString();
            }
        }

        // Handle CRUD Operations:
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                if (cbxSubcategory.SelectedItem != null)
                {
                    if (cbxSmallUnit.SelectedItem == null && cbxLargeUnit.SelectedItem == null)
                    {
                        MessageBox.Show("يجب اختيار الوحدة  الكبرى أو الوحدة الصغرى للمنتج ", "تأكيد", MessageBoxButtons.OK);
                        return;
                    }
                    if(MessageBox.Show("تم الإضافة بنجاح هل ترغب في إضافة صنف أخر", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (rbSmallUnitIsMainUnit.Checked)
                        {
                            IsUnitSale = false;
                            AddProductAndCLearUsercontrol();

                        }
                        else
                        {
                            IsUnitSale = true;
                            AddProductAndCLearUsercontrol();
                        }
                        return;
                    }          
                    else
                    {
                        if (rbSmallUnitIsMainUnit.Checked)
                        {
                            IsUnitSale = false;
                            AddProductAndCLearUsercontrol();

                        }
                        else
                        {
                            IsUnitSale = true;
                            AddProductAndCLearUsercontrol();
                        }

                        // Navigate to AllProuductView:
                        if (!frmMainBoard.Instance.gcContainer.Contains(ucAllProductsView.Instance))
                        {
                            frmMainBoard.Instance.Controls.Add(ucAllProductsView.Instance);
                            ucAllProductsView.Instance.Dock = DockStyle.Fill;
                            ucAllProductsView.Instance.BringToFront();
                        }
                        ucAllProductsView.Instance.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("يجب اختيار التصنيف الفرعي للمنتج", "تأكيد", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("يجب أدخل اسم المنتج", "تأكيد", MessageBoxButtons.OK);
                return;
            }

           
        }

        private void AddProductAndCLearUsercontrol()
        {
            if(cbxSmallUnit.SelectedItem != null)
            {
                SmallUnitId = new Guid (cbxSmallUnit.SelectedValue.ToString());
            }
            
            Presenter.OnCLickbtnAdd();
            txtName.Text = txtDescription.Text = "";
            txtLimitedDemand.Text = txtQuantity.Text = txtUCPNumber.Text
                = txtCBCNumber.Text = txtPSNNumber.Text = "0";
            nudDefaultPurchasePrice.Value = nudDefaultSalePrice.Value = nudDefaultWholesalePrice.Value
                = nudVATPercent.Value = nudDiscountPercent.Value = 0m;
            cbxLargeUnit.SelectedIndex = cbxSmallUnit.SelectedIndex = cbxSubcategory.SelectedIndex = -1;
        }

       
    }
}
