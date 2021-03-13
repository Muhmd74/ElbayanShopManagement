using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Store.Product.AllProduct;
using ElbayaNPresentation.Presenters.Store.Product.ProductCard;
using ElbayanServices.Repository.Products.Product.Dtos;
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
    public partial class ucAllProductsView : DevExpress.XtraEditors.XtraUserControl, IViewAllProduct
    {
        public ucAllProductsView()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new AllProductPresenter(this);
            Presenter.OnLoadUC();
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

        public Guid ID { get; set; }
        public AllProductPresenter Presenter { get;  set; }
        public Guna2TextBox SearchKeyword { get => txtSearch; set => txtSearch = value; }
        public DataGridView ActiveObject { get => dgvAllProduct; set => dgvAllProduct = value; }
        public DataGridView DeletedObject { get => dgvAllDeletedProduct; set => dgvAllDeletedProduct = value; }


        private void dgvTabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvTabContainer.SelectedIndex == 0)
            {
               // dgvAllProduct.DataSource = Presenter.PopulatedgvAllproduct();
            }
            else if (dgvTabContainer.SelectedIndex == 1)
            {
                DataGridViewStyle.StyleDatagridview(dgvAllDeletedProduct);
                //dgvAllDeletedProduct.DataSource = Presenter.PopulatedgvDeletedAllproduct();

            }
        }

        private void dgvAllProduct_DoubleClick(object sender, EventArgs e)
        {
            Presenter.PopulatefrmNewProduct();
            frmNewProduct.Instance.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Presenter.OnTextSearchChanged();
        }

    }
}
