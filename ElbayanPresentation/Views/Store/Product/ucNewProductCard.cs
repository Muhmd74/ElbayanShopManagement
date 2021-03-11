using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
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
    public partial class ucNewProductCard : DevExpress.XtraEditors.XtraUserControl//, IViewNewProdcut
    {
        public ucNewProductCard()
        {
            InitializeComponent();
            
            //Presenter = new ProductPresnter(this);

            _instance = this;

            txtUCPNumber.Focus();

            Presenter.ucNewProudctCard_Load();
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
        public Guna2ComboBox SubCategory { get => cbxSubcategory; set => cbxSubcategory.SelectedValue = value; }
        public bool IsExpired { get => rbIsExpiredProduct.Checked; set => rbIsExpiredProduct.Checked = value; }
        public Guna2ComboBox LargeUnit { get => cbxLargeUnit ; set => cbxLargeUnit.SelectedValue = value; } 
        public Guna2ComboBox SmallUnit { get => cbxSmallUnit; set => cbxSmallUnit.SelectedValue = value; }
        public Guna2TextBox LimitedDemand { get => txtLimitedDemand; set => txtLimitedDemand = value; }
        public Guna2TextBox ProductQuantity { get => txtQuantity; set => txtQuantity = value; }
        public ProductPresnter Presenter { private get; set; }
        public NumericUpDown Disccount { get => nudDiscountPercent; set => nudDiscountPercent = value; }
        public NumericUpDown VAT { get => nudVATPercent; set => nudVATPercent = value; }


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
              
        // Populate Small unit Baesd on Large unit
        private void cbxLargeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.FillcbxSmallunit();

        }

        // Validate text box for only numbers
       
              
        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            txtCBCNumber.Text = Presenter.GenerateProductNumber().ToString();
        }

        private void txtLimitedDemand_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateControls.ValidateTextBoxOnlyNumber(sender, e, txtLimitedDemand);
        }

        private void txtUCPNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateControls.ValidateTextBoxOnlyNumber(sender, e, txtUCPNumber);
            
            // Read Barcod:
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
                            Presenter.OnCLickbtnAdd();
                            ClearUC();
                        }
                        else
                        {
                            IsUnitSale = true;
                            Presenter.OnCLickbtnAdd();
                            ClearUC();
                        }
                        return;
                    }          
                    else
                    {
                        if (rbSmallUnitIsMainUnit.Checked)
                        {
                            IsUnitSale = false;
                            Presenter.OnCLickbtnAdd();
                            ClearUC();
                        }
                        else
                        {
                            IsUnitSale = true;
                            Presenter.OnCLickbtnAdd();
                            ClearUC();
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

       // Handle Update
        private void btnUpdate_Click(object sender, EventArgs e)
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
                    if (MessageBox.Show("تم الإضافة بنجاح هل ترغب في إضافة صنف أخر", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (rbSmallUnitIsMainUnit.Checked)
                        {
                            IsUnitSale = false;
                            Presenter.OnCLickbtnUpdate();
                            ClearUC();
                        }
                        else
                        {
                            IsUnitSale = true;
                            Presenter.OnCLickbtnUpdate();
                            ClearUC();
                        }
                        return;
                    }
                    else
                    {
                        if (rbSmallUnitIsMainUnit.Checked)
                        {
                            IsUnitSale = false;
                            Presenter.OnCLickbtnUpdate();
                            ClearUC();
                        }
                        else
                        {
                            IsUnitSale = true;
                            Presenter.OnCLickbtnUpdate();
                            ClearUC();
                        }

                        // Navigate to AllProuductView:
                        if (!frmMainBoard.Instance.gcContainer.Contains(ucAllProductsView.Instance))
                        {
                            frmMainBoard.Instance.Controls.Add(ucAllProductsView.Instance);
                            ucAllProductsView.Instance.Dock = DockStyle.Fill;
                            ucAllProductsView.Instance.BringToFront();
                        }
                        ucAllProductsView.Instance.BringToFront();
                        ucAllProductsView.Instance.dgvAllProduct.DataSource = ucAllProductsView.Instance.Presenter.PopulatedgvAllproduct();

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

        // Clear User interface controlls:
        private void ClearUC()
        {
            txtName.Text = txtDescription.Text = "";
            txtLimitedDemand.Text = txtQuantity.Text = txtUCPNumber.Text
                = txtCBCNumber.Text = txtPSNNumber.Text = "0";
            nudDefaultPurchasePrice.Value = nudDefaultSalePrice.Value = nudDefaultWholesalePrice.Value
                = nudVATPercent.Value = nudDiscountPercent.Value = 0m;
            cbxLargeUnit.SelectedIndex = cbxSmallUnit.SelectedIndex = cbxSubcategory.SelectedIndex = -1;
            pbProductImage.Image = null;
        }

        private void cbxSmallUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
