using ElbayanDatabase.ConnectionTools;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductCard
{
    public class ProductPresnter
    {
        private readonly IViewProdcut _view;

        private readonly ProductService productServices = new ProductService(new ConnectionOption());
        
        public ProductPresnter(IViewProdcut view)
        {
            _view = view;
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
                _view.SmallUnit.DataSource = productServices.GetAllSmallUnitByLargeUnit(LargeUnitId).ToList();
            }
            else
            {
                _view.SmallUnit.DataSource = null;
            }
            _view.SmallUnit.DisplayMember = "Name";
            _view.SmallUnit.ValueMember = "SmallUnitId";
            _view.SmallUnit.SelectedValue = "SmallUnitId";
        }

        // Generate Random number 

        public long GenerateProductNumber()
        {
           return  productServices.GenerateProductNumber();
        }
       // CRUD Operations:
       // Create:: 
        public void OnCLickbtnAdd()
        {
            productServices.Add(new ProductDto
            {
                Name = _view.ProudctName.Text,
                Description = _view.Description.Text,
                BarCode = Convert.ToInt32(_view.BarCode.Text),
                SubCategoryId = new Guid( _view.SubCategory.SelectedValue.ToString()),
                LargeUnitId = new Guid(_view.LargeUnit.SelectedValue.ToString()),
                SmallUnitId = new Guid (_view.SmallUnit.SelectedValue.ToString()),
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
                Id = _view.ProductId,               
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
        public void Onlynumwithsinglepoint(object sender, KeyPressEventArgs e, Guna2TextBox textBox)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }

        }
   
    
    }
}
