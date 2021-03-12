using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Views.Store.Product;
using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.Product.Dtos;
using System;
using System.Collections.Generic;
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

        public void PopulatefrmNewProduct()
        {
            _view.ID = new Guid(_view.ActiveObject.CurrentRow.Cells["ProductId"].Value.ToString());
            var model = productSerice.GetById(_view.ID);

            frmNewProduct.Instance.ID = model.Id;
            frmNewProduct.Instance.txtName.Text = model.Name;
            frmNewProduct.Instance.txtDescription.Text = model.Description;
            frmNewProduct.Instance.txtLimitedDemand.Text = model.LimitedDemand.ToString();
            // frmNewProduct.Instance.txtQuantity.Text = model.Quantity;
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
            frmNewProduct.Instance.rbIsExpiredProduct.Checked = model.IsExpired;
                       
            //string ImageUrl = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\ProductImage\", Path.GetFileName("Photos-icon.png"));

            //if (frmNewProduct.Instance.Acti.CurrentRow.Cells["ImageUrl"].Value != null)
            //{
            //    ImageUrl = dgvAllProduct.CurrentRow.Cells["ImageUrl"].Value.ToString();
            //    ucNewProductCard.Instance.pbProductImage.Image = new Bitmap(ImageUrl);
            //}
            //else
            //{
            //    ucNewProductCard.Instance.pbProductImage.Image = new Bitmap(ImageUrl);
            //}
            //frmMainBoard.Instance.Visible = false;

        }

    }
}
