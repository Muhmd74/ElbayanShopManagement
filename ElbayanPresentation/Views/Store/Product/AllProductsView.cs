using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.Store.Product.AllProduct;
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
    public partial class AllProductsView : DevExpress.XtraEditors.XtraUserControl, IViewAllProduct
    {
        public AllProductsView()
        {
            InitializeComponent();
            Presenter = new AllProductPresenter(this);
            PopulatedgvAllProduct();
        }
        private static AllProductsView _instance;
        public static AllProductsView Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AllProductsView();
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
    }
}
