using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Store.Product.AllProduct;
using ElbayaNPresentation.Presenters.Store.Product.ProductCard;
using ElbayanServices.Repository.Products.Product.Dtos;
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
    public partial class ucAllProductsView : DevExpress.XtraEditors.XtraUserControl, IViewAllProduct
    {
        public ucAllProductsView()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new AllProductPresenter(this);
            PopulatedgvAllProduct();
        }
        private static ucAllProductsView _instance;
        public static ucAllProductsView Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAllProductsView();
                return _instance;
            }
        }

        public string SearchKeyword { get => txtSearch.Text; set => txtSearch.Text = value; }
        public List<ProductDto> products { get; set; }
        public AllProductPresenter Presenter { get;  set; }

        public void PopulatedgvAllProduct()
        {
            dgvAllProduct.DataSource = Presenter.PopulatedgvAllproduct();
            DataGridViewStyle.StyleDatagridview(dgvAllProduct);
            dgvAllProduct.AutoGenerateColumns = false;

            // Organize DGV Columns:

            dgvAllProduct.Columns["ProductName"].DisplayIndex = 0;
            dgvAllProduct.Columns["ProductCategory"].DisplayIndex = 1;
            dgvAllProduct.Columns["IsMainSaleUnit"].DisplayIndex = 2;
            dgvAllProduct.Columns["UCPNumber"].DisplayIndex = 3;
            dgvAllProduct.Columns["CBCNumber"].DisplayIndex = 4;
            dgvAllProduct.Columns["PSNumber"].DisplayIndex = 5;
            dgvAllProduct.Columns["PurchaseDefaultPrice"].DisplayIndex = 6;
            dgvAllProduct.Columns["SaleDefaultPrice"].DisplayIndex = 7;
            dgvAllProduct.Columns["WholesalePrice"].DisplayIndex = 8;
            dgvAllProduct.Columns["Discount"].DisplayIndex = 9;
            dgvAllProduct.Columns["VAT"].DisplayIndex = 10;

        }

        private void dgvAllProduct_DoubleClick(object sender, EventArgs e)
        {
            if (!frmMainBoard.Instance.gcContainer.Contains(ucNewProductCard.Instance))
            {
                frmMainBoard.Instance.gcContainer.Controls.Add(ucNewProductCard.Instance);
                ucNewProductCard.Instance.Dock = DockStyle.Fill;
                ucNewProductCard.Instance.BringToFront();
                //PopulateucNewProuct();

            }
            ucNewProductCard.Instance.BringToFront();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvTabContainer.SelectedIndex == 0)
            {
                dgvAllProduct.DataSource = Presenter.FilterDataGridView().ToList();
            }
            else if (dgvTabContainer.SelectedIndex == 1)
            {
                //dgvAllDeletedProduct.DataSource = Presenter.FilterDataGridViewDeleted();
            }
        }

        private void dgvTabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvTabContainer.SelectedIndex == 0)
            {
                dgvAllProduct.DataSource = Presenter.PopulatedgvAllproduct();
            }
            else if (dgvTabContainer.SelectedIndex == 1)
            {
                DataGridViewStyle.StyleDatagridview(dgvAllDeletedProduct);
                dgvAllDeletedProduct.DataSource = Presenter.PopulatedgvDeletedAllproduct();

            }
        }

        private void dgvAllProduct_DoubleClick_1(object sender, EventArgs e)
        {
            if(dgvAllProduct.CurrentRow.Index != -1)
            {
                if (!frmMainBoard.Instance.gcContainer.Controls.Contains(ucNewProductCard.Instance))
                {
                    frmMainBoard.Instance.gcContainer.Controls.Add(ucNewProductCard.Instance);
                    ucNewProductCard.Instance.Dock = DockStyle.Fill;
                    ucNewProductCard.Instance.BringToFront();
                }
                ucNewProductCard.Instance.BringToFront();
                PopulateucNewProuct();
            }
        }
        private void PopulateucNewProuct()
        {
            // string productName = dgvAllProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            // Enable Edite and Delete Buttons.
            ucNewProductCard.Instance.btnAdd.Enabled = false;

            ucNewProductCard.Instance.btnUpdate.Visible = true;
            ucNewProductCard.Instance.btnUpdate.Enabled = true;

            ucNewProductCard.Instance.btnDeleteByOne.Enabled = true;
            ucNewProductCard.Instance.btnDeleteByOne.Visible = true;

            // Fill controlls with data:
            ucNewProductCard.Instance.ProudctName.Text = dgvAllProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            ucNewProductCard.Instance.Description.Text = dgvAllProduct.CurrentRow.Cells["ProductDescription"].Value.ToString();
            ucNewProductCard.Instance.VAT = Convert.ToInt32(dgvAllProduct.CurrentRow.Cells["VAT"].Value);
            ucNewProductCard.Instance.LargeUnit.Text = dgvAllProduct.CurrentRow.Cells["LargeUnitName"].Value.ToString();

            // Handle Default Picture:
            string ImageUrl = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\ProductImage\", Path.GetFileName("Photos-icon.png"));

                if (dgvAllProduct.CurrentRow.Cells["ImageUrl"].Value != null)
                {
                    ImageUrl = dgvAllProduct.CurrentRow.Cells["ImageUrl"].Value.ToString();
                    ucNewProductCard.Instance.pbProductImage.Image = new Bitmap(ImageUrl);
                }
                else
                {
                    ucNewProductCard.Instance.pbProductImage.Image = new Bitmap(ImageUrl);
                }

            ucNewProductCard.Instance.txtPSNNumber.Text = dgvAllProduct.CurrentRow.Cells["PSNumber"].Value.ToString();
        }
    }
}
