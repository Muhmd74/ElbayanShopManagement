using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Views.Store.Product;
using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.Product.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Product.AllProduct
{
    public class AllProductPresenter
    {
        private readonly IViewAllProduct _view;
        private readonly ProductService productSerice = new ProductService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public AllProductPresenter(IViewAllProduct view)
        {
            _view = view;
        }

        public void OnLoadUC()
        {
            DataGridViewStyle.StyleDatagridview(_view.ActiveObject);
            DataGridViewStyle.StyleDatagridview(_view.DeletedObject);
            PopulatedgvAllProduct();
            PopulatedgvDeletedObject();
        }
        public void PopulatedgvAllProduct()
        {
            _view.ActiveObject.DataSource = productSerice.GetAll().ToList();
            _view.ActiveObject.AutoGenerateColumns = false;
            // Organize DGV Columns:
            _view.ActiveObject.Columns["ProductName"].DisplayIndex = 0;
            _view.ActiveObject.Columns["ProductCategory"].DisplayIndex = 1;
            _view.ActiveObject.Columns["IsMainSaleUnit"].DisplayIndex = 2;
            _view.ActiveObject.Columns["UCPNumber"].DisplayIndex = 3;
            _view.ActiveObject.Columns["CBCNumber"].DisplayIndex = 4;
            _view.ActiveObject.Columns["PSNumber"].DisplayIndex = 5;
            _view.ActiveObject.Columns["PurchaseDefaultPrice"].DisplayIndex = 6;
            _view.ActiveObject.Columns["SaleDefaultPrice"].DisplayIndex = 7;
            _view.ActiveObject.Columns["WholesalePrice"].DisplayIndex = 8;
            _view.ActiveObject.Columns["Discount"].DisplayIndex = 9;
            _view.ActiveObject.Columns["VAT"].DisplayIndex = 10;
        }
        public void PopulatedgvDeletedObject()
        {
            _view.DeletedObject.DataSource = productSerice.GetAllProductDeleted().ToList();
            _view.DeletedObject.AutoGenerateColumns = false;
            //// Organize DGV Columns:
            //_view.ActiveObject.Columns["ProductName"].DisplayIndex = 0;
            //_view.ActiveObject.Columns["ProductCategory"].DisplayIndex = 1;
            //_view.ActiveObject.Columns["IsMainSaleUnit"].DisplayIndex = 2;
            //_view.ActiveObject.Columns["UCPNumber"].DisplayIndex = 3;
            //_view.ActiveObject.Columns["CBCNumber"].DisplayIndex = 4;
            //_view.ActiveObject.Columns["PSNumber"].DisplayIndex = 5;
            //_view.ActiveObject.Columns["PurchaseDefaultPrice"].DisplayIndex = 6;
            //_view.ActiveObject.Columns["SaleDefaultPrice"].DisplayIndex = 7;
            //_view.ActiveObject.Columns["WholesalePrice"].DisplayIndex = 8;
            //_view.ActiveObject.Columns["Discount"].DisplayIndex = 9;
            //_view.ActiveObject.Columns["VAT"].DisplayIndex = 10;
        }
        internal static long? BarecodeNumber(string BareCodeInupt)
        {
            long Barcode;
            return Int64.TryParse(BareCodeInupt, out Barcode) ? (long?)Barcode : null;
        }internal static int? ProductNumber(string ProductNumberInupt)
        {
            int ProductNumber;
            return Int32.TryParse(ProductNumberInupt, out ProductNumber) ? (int?)ProductNumber : null;
        }
        internal void OnTextSearchChanged()
        {
            string productName = _view.SearchKeyword.Text;
            long? Barcode = BarecodeNumber(_view.SearchKeyword.Text);
            int? ProductNymber = ProductNumber(_view.SearchKeyword.Text);
            _view.ActiveObject.DataSource =  productSerice.GetByName(productName, Barcode, ProductNymber).ToList();
        }
        public void PopulatefrmNewProduct()
        {
            if(_view.TabContainer.SelectedIndex == 0)
            {
                _view.ID = new Guid(_view.ActiveObject.CurrentRow.Cells["ProductId"].Value.ToString());
            }
            else if (_view.TabContainer.SelectedIndex == 1)
            {
                _view.ID = new Guid(_view.DeletedObject.CurrentRow.Cells["DeletedObjectID"].Value.ToString());

            }
            else if (_view.TabContainer.SelectedIndex == 2)
            {
                //_view.ID = new Guid(_view.ActiveObject.CurrentRow.Cells["ProductId"].Value.ToString());

            }
            var model = productSerice.GetById(_view.ID);
            frmNewProduct.Instance.ID = model.Id;
            frmNewProduct.Instance.txtName.Text = model.Name;
            frmNewProduct.Instance.txtDescription.Text = model.Description;
            frmNewProduct.Instance.txtLimitedDemand.Text = model.LimitedDemand.ToString();
            frmNewProduct.Instance.txtUCPNumber.Text = model.UCP.ToString();
            frmNewProduct.Instance.txtCBCNumber.Text = model.BarCode.ToString();
            frmNewProduct.Instance.txtPSNNumber.Text = model.ProductNumber.ToString();
            frmNewProduct.Instance.nudDefaultPurchasePrice.Value = model.PurchaseDefaultPrice;
            frmNewProduct.Instance.nudDefaultSalePrice.Value = model.SaleDefaultPrice;
            frmNewProduct.Instance.nudDefaultWholesalePrice.Value = model.WholesalePrice;
            frmNewProduct.Instance.nudVATPercent.Value = model.Vat;
            frmNewProduct.Instance.nudDiscountPercent.Value = model.Discount;
            frmNewProduct.Instance.cbxSubcategory.Text = model.SubCategoryName;
            frmNewProduct.Instance.cbxLargeUnit.Text = model.LargeUnitName;
            frmNewProduct.Instance.cbxSmallUnit.Text = model.SmallUnitName;
            frmNewProduct.Instance.cbIsExpired.Checked = model.IsExpired;
            frmNewProduct.Instance.txtQuantity.Text = model.TotalQuantity.ToString();
            frmNewProduct.Instance.cbIsDeleted.Visible = true;
            frmNewProduct.Instance.cbIsDeleted.Checked = model.IsDeleted;
            
            if(model.IsUnitSale == true)
            {
                frmNewProduct.Instance.rbLargeUnitIsMainUnit.Checked = true;
                frmNewProduct.Instance.rbSmallUnitIsMainUnit.Checked = false;
            }
            else
            {
                frmNewProduct.Instance.rbLargeUnitIsMainUnit.Checked = false;
                frmNewProduct.Instance.rbSmallUnitIsMainUnit.Checked = true;
            }

            string ImageUrl = model.ImageUrl;

            if (!string.IsNullOrEmpty(ImageUrl))
            {
                frmNewProduct.Instance.pbProductImage.Image = new Bitmap(ImageUrl);
            }
            else
            {
                frmNewProduct.Instance.pbProductImage.Image = null;
            }
            frmNewProduct.Instance.btnUpdate.Visible = true;
            frmNewProduct.Instance.btnDeleteOrRestore.Visible = true;
        }
    }
}
