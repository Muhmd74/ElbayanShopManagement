using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Views.Store.Product;
using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.Product.Dtos;
using ElbayanServices.Repository.Products.SubCategory;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using ElbayanServices.Repository.Products.Units.LargeUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductCard
{
    public class ProductPresnter
    {
        private readonly IViewNewProdcut _view;

        private readonly ProductService productServices = new ProductService(new ConnectionOption());
        
        public ProductPresnter(IViewNewProdcut view)
        {
            _view = view;
        }

        public void UploadPicture()
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "ملفات الصور (*.jpg; *.jpeg; *.gif; *.png; *.bmp;) | *.jpg; *.jpeg; *.gif; *.png; *.bmp;";
            if (image.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(image.FileName))
            {
                _view.ProductPicture.Image = new Bitmap(image.FileName);
                _view.ImageUrl = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\ProductImage\", Path.GetFileName(image.FileName));
                if (File.Exists(_view.ImageUrl))
                {
                    File.Delete(_view.ImageUrl);
                }
                //File.Move(@"c:\test\SomeFile.txt", @"c:\test\Test\SomeFile.txt");
                File.Copy(image.FileName, _view.ImageUrl);
            }
        }
        public void ucNewProudctCard_Load()
        {
            // hide Unmeric up down Arrows:
            _view.PurchaseDefaultPrice.Controls[0].Visible = false;
            _view.SaleDefaultPrice.Controls[0].Visible = false;
            _view.WholesalePrice.Controls[0].Visible = false;
            _view.VAT.Controls[0].Visible = false;
            _view.Disccount.Controls[0].Visible = false;

            FillcbxLargeUnit();
            FillcbxSubcategory();
            FillcbxSmallunit();
        }
        public void FillcbxSubcategory()
        {
            _view.SubCategory.DisplayMember = "Name";
            _view.SubCategory.ValueMember = "Id";
            _view.SubCategory.SelectedValue = "Id";
            _view.SubCategory.DataSource = productServices.GetAllSubCategory().ToList();
        }
        public void FillcbxLargeUnit()
        {
            _view.LargeUnit.DisplayMember = "Name";
            _view.LargeUnit.ValueMember = "LargeUnitId";
            _view.LargeUnit.SelectedValue = "LargeUnitId";
            _view.LargeUnit.DataSource = productServices.GetAllLargeUnit().ToList();
        }
        public void FillcbxSmallunit()
        {
            if (_view.LargeUnit.SelectedItem != null)
            {
                Guid LargeUnitId = new Guid(_view.LargeUnit.SelectedValue.ToString());
                // bool AreGetLargeUnitId = Guid.TryParse(_view.LargeUnit.SelectedValue.ToString(), out LargeUnitId);
                productServices.GetAllSmallUnitByLargeUnit(LargeUnitId);
                _view.SmallUnit.DisplayMember = "Name";
                _view.SmallUnit.ValueMember = "SmallUnitId";
                _view.SmallUnit.SelectedValue = "SmallUnitId";
                _view.SmallUnit.DataSource = productServices.GetAllSmallUnitByLargeUnit(LargeUnitId).ToList();
            }
            else
            {
                _view.SmallUnit.DataSource = null;
            }
          
        }

        // Generate Random number 

        public long GenerateProductNumber()
        {
            return productServices.GeneratorRandomNumber();
        }
       // CRUD Operations:
       // Create:: 
        public void OnCLickbtnAdd()
        {
            if (_view.ProudctName.Text != string.Empty)
            {
                if (_view.SubCategory.SelectedItem != null)
                {
                    if (_view.LargeUnit.SelectedItem == null && _view.SmallUnit.SelectedItem == null)
                    {
                        MessageBox.Show("يجب اختيار الوحدة  الكبرى أو الوحدة الصغرى للمنتج ", "تأكيد", MessageBoxButtons.OK);
                        return;
                    }
                    if (MessageBox.Show("تم الإضافة بنجاح هل ترغب في إضافة صنف أخر", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (_view.SmallUnitIsMainUnit.Checked)
                        {
                            _view.IsUnitSale = false;
                            CreateObject();
                            ClearControls();
                        }
                        else
                        {
                            CreateObject();
                            ClearControls();
                        }
                    }
                    else
                    {
                        if (_view.SmallUnitIsMainUnit.Checked)
                        {
                            _view.IsUnitSale = false;
                            CreateObject();
                            ClearControls();
                        }
                        else
                        {
                            CreateObject();
                            ClearControls();
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
        private void CreateObject()
        {
            productServices.Add(new ProductDto
            {
                Name = _view.ProudctName.Text,
                Description = _view.Description.Text,
                BarCode = Convert.ToInt32(_view.BarCode.Text),
                SubCategoryId = new Guid(_view.SubCategory.SelectedValue.ToString()),
                LargeUnitId = new Guid(_view.LargeUnit.SelectedValue.ToString()),
                SmallUnitId = new Guid(_view.SmallUnit.SelectedValue.ToString()),
                IsUnitSale = _view.IsUnitSale,
                LimitedDemand = Convert.ToInt32(_view.LimitedDemand.Text),
                IsExpired = _view.IsExpired,
                ImageUrl = _view.ImageUrl,
                UCP = Convert.ToInt32(_view.UCP.Text),
                PurchaseDefaultPrice = _view.PurchaseDefaultPrice.Value,
                SaleDefaultPrice = _view.SaleDefaultPrice.Value,
                WholesalePrice = _view.WholesalePrice.Value,
                //IsMAinSalesUnit = _view.IsMainSaleUnit,
                Vat = Convert.ToInt32(_view.VAT.Text),
                Discount = Convert.ToInt32(_view.Disccount.Text)
            });
        }
        // Retrive Handled by ucAllProduct

        // Update::
        public void OnCLickbtnUpdate()
        {
            productServices.Update( new ProductDto { 
                Id = _view.ID,               
                Name = _view.ProudctName.Text,
                Description = _view.Description.Text,
                SubCategoryId = new Guid (_view.SubCategory.SelectedValue.ToString()),
                LargeUnitId = new Guid(_view.LargeUnit.SelectedValue.ToString()),
                SmallUnitId = new Guid(_view.SmallUnit.SelectedValue.ToString()),
                IsUnitSale = _view.IsUnitSale,
                LimitedDemand = Convert.ToInt32(_view.LimitedDemand.Text),
               
                UCP = Convert.ToInt32(_view.UCP.Text),
                BarCode = Convert.ToInt32(_view.BarCode.Text),
                ProductNumber = Convert.ToInt32(_view.PSNumber.Text),

                PurchaseDefaultPrice = _view.PurchaseDefaultPrice.Value,
                SaleDefaultPrice = _view.SaleDefaultPrice.Value,
                WholesalePrice = _view.WholesalePrice.Value,
                Discount = Convert.ToInt32(_view.Disccount.Value), // needed to be decimal
                Vat = Convert.ToInt32(_view.VAT.Value),
                ImageUrl = _view.ImageUrl,
           });
        }

        // Validate Text box for only numbers:

        private void ClearControls()
        {
            _view.ProudctName.Text = _view.Description.Text = "";
            _view.LimitedDemand.Text = _view.UCP.Text
                = _view.BarCode.Text = _view.PSNumber.Text = "0";
            _view.PurchaseDefaultPrice.Value = _view.SaleDefaultPrice.Value = _view.WholesalePrice.Value
                = _view.VAT.Value = _view.Disccount.Value = 0m;
            _view.SubCategory.SelectedIndex = _view.LargeUnit.SelectedIndex = _view.SmallUnit.SelectedIndex = -1;
            _view.ProductPicture.Image = null;
        }


    }
}
