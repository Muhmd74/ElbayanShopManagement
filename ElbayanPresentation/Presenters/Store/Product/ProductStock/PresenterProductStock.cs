using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.ProductStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductStock
{
    public class PresenterProductStock
    {
        private readonly IViewProductStoc _view;
        private readonly ProductStockService ProductStock = new ProductStockService(new ConnectionOption());
        public PresenterProductStock(IViewProductStoc view)
        {
            _view = view;
        }
        internal void OnLoad()
        {
            PopulateActiveProduct.PopulateProducts(_view.ActiveProduct);
        }
    }
}
