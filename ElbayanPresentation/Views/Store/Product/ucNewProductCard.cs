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

            PopulatecbxSubcategory();
            PopulatecbxLargeUnit();
            PopulatecbxSmallUnit();
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
        public bool IsUnitSale { get; set; }
        public Guid SubCategoryId { get => new Guid(cbxSubcategory.SelectedValue.ToString()); set => cbxSubcategory.SelectedValue = value; }
        public SubCategoryDto SubCategory { get; set; }
        public bool IsExpired { get => rbIsExpiredProduct.Checked; set => rbIsExpiredProduct.Checked = value; }
        public DateTime ExpireDateTime { get => dtpExpireDate.Value; set => dtpExpireDate.Value = value; }
        public Guid LargeUnitId { get => new Guid (cbxLargeUnit.SelectedValue.ToString()); set => cbxLargeUnit.SelectedValue = value; }
        public LargeUnitDto LargeUnit { get; set; }
        public List<LargeUnitDto> LargeUnits { get; set; }
        public Guid SmallUnitId { get => new Guid(cbxSmallUnit.SelectedValue.ToString()); set => cbxSmallUnit.SelectedValue = value; }
        public SmallUnitDto SmallUnit { get; set; }
        public List<SmallUnitDto> smallUnits { get; set; }
        public int LimitedDemand { get => Convert.ToInt32(txtLimitedDemand.Text); set => Convert.ToInt32(txtLimitedDemand.Text); }
        public ProductPresnter Presenter { private get; set; }
        public List<SubCategoryDto> SubCategories { get; set; }

        // Handle Picture Uplode
        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            string ImageName = "";
            
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "ملفات الصور (*.jpg; *.jpeg; *.gif; *.png; *.bmp;) | *.jpg; *.jpeg; *.gif; *.png; *.bmp;";
            if (image.ShowDialog() == DialogResult.OK )
            {
                ImageName = image.FileName;
                pbProductImage.Image = new Bitmap(image.FileName);
            }
            ImageUrl = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\ProductImage\", Path.GetFileName(ImageName));
            if (File.Exists(ImageUrl))
            {
                File.Delete(ImageUrl);
            }
            //File.Move(@"c:\test\SomeFile.txt", @"c:\test\Test\SomeFile.txt");
            File.Copy(ImageName, ImageUrl);
        }

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
            cbxLargeUnit.ValueMember = "Id";
            cbxLargeUnit.SelectedValue = "Id";
        }
        private void PopulatecbxSmallUnit() 
        {
            cbxSmallUnit.DataSource = Presenter.FillcbxSmallunit();
            cbxSmallUnit.DisplayMember = "Name";
            cbxSmallUnit.ValueMember = "Id";
            cbxSmallUnit.SelectedValue = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text != string.Empty)
            {
                if (cbxSubcategory.SelectedItem != null)
                {
                    if(txtLimitedDemand.Text.Trim() == string.Empty)
                    {
                        txtLimitedDemand.Text = "0";
                    }
                    if (txtCBCNumber.Text.Trim() == string.Empty)
                    {
                        txtCBCNumber.Text = "0";
                    }
                    if (txtUCPNumber.Text.Trim() == string.Empty)
                    {
                        txtUCPNumber.Text = "0";
                    }
                    if (txtPSNNumber.Text.Trim() == string.Empty)
                    {
                        txtPSNNumber.Text = "0";
                    }
                    if(cbxSmallUnit.SelectedItem == null)
                    {
                        MessageBox.Show("يجب اختيار الوحدة الكبرى للمنتج", "تأكيد", MessageBoxButtons.OK);
                        return;
                    }
                    if (cbxLargeUnit.SelectedItem == null)
                    {
                        MessageBox.Show("يجب اختيار الوحدة الصغرى للمنتج", "تأكيد", MessageBoxButtons.OK);
                        return;
                    }
                    if (rbSmallUnitIsMainUnit.Checked)
                    {
                        IsUnitSale = false;
                        Presenter.OnCLickbtnAdd();
                    }
                    else
                    {
                        Presenter.OnCLickbtnAdd();
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

            // Navigate to AllProuductView:
            if (!frmMainBoard.Instance.gcContainer.Contains(ucAllProductsView.Instance))
            {
                frmMainBoard.Instance.Controls.Add(ucAllProductsView.Instance);
                ucAllProductsView.Instance.Dock = DockStyle.Fill;
                ucAllProductsView.Instance.BringToFront();
            }
            ucAllProductsView.Instance.BringToFront();
        }

       
      
        // Validate text box for only numbers
        private void txtLimitedDemand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUCPNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCBCNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
