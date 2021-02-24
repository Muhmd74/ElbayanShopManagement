using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.Store.Product.AllProduct;
using ElbayaNPresentation.Presenters.Store.Product.ProductCard;
using ElbayanServices.Repository.Products.Product.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public AllProductPresenter Presenter { private get;  set; }

        public void PopulatedgvAllProduct()
        {
            dgvAllProduct.DataSource = Presenter.PopulatedgvAllproduct();
        }

        private void dgvAllProduct_DoubleClick(object sender, EventArgs e)
        {
            if (!frmMainBoard.Instance.gcContainer.Contains(ucNewProductCard.Instance))
            {
                frmMainBoard.Instance.gcContainer.Controls.Add(ucNewProductCard.Instance);
                ucNewProductCard.Instance.Dock = DockStyle.Fill;
                ucNewProductCard.Instance.BringToFront();
                PopulateucNewProuct();
            }
            ucNewProductCard.Instance.BringToFront();
        }

        private void PopulateucNewProuct()
        {
            // string productName = dgvAllProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            ucNewProductCard.Instance.txtName.Text = dgvAllProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            ucNewProductCard.Instance.txtPSNNumber.Text = dgvAllProduct.CurrentRow.Cells["ProductNumber"].Value.ToString();
        }
    }
}
