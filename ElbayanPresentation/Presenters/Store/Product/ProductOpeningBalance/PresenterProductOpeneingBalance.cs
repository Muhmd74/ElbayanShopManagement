using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.ProductStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductOpeningBalance
{
    public class PresenterProductOpeneingBalance
    {
        private IViewProductOpeningBakance _view;
        private ProductStockService OpeningBalance =
            new ProductStockService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterProductOpeneingBalance(IViewProductOpeningBakance view)
        {
            _view = view;
            _view.AddObject.Click += new EventHandler(CreateObject_OnCLick);
        }

        public void OnLOad()
        {
            PopulateActiveProduct.PopulateProducts(_view.ActiveProduct);
        }
        private void CreateObject_OnCLick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_view.ProductStock.Text) 
                && !string.IsNullOrWhiteSpace(_view.ProductStock.Text))
            {
                if (_view.ActiveProduct.SelectedIndex != -1)
                {
                    decimal stockDe = Convert.ToDecimal(_view.ProductStock.Text);
                    int stock = Convert.ToInt32(stockDe);
                    Guid ProductId = new Guid(_view.ActiveProduct.SelectedValue.ToString());
                    OpeningBalance.CreateOpeningBalancesProduct(stock, ProductId);
                    MessageBox.Show("تمت العملية بنجاح", "تأكيد", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("لا بد من اختيار منتج", "تأكيد", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("لا بد من إدخال كمية منتج", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        } 
    }
}
