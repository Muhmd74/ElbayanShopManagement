using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.ProductStock;
using ElbayanServices.Repository.Products.ProductStock.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductStock
{
    public class PresenterProductStock
    {
        private readonly IViewProductStock _view;
        private readonly ProductStockService ProductStock = new ProductStockService(new ConnectionOption());
        public PresenterProductStock(IViewProductStock view)
        {
            _view = view;
            _view.SearchResult.DataSource = GetAllProductStockDetails();
            //_view.Search.Click += new EventHandler(OnCLickSearchbtn);
            _view.Search.Click += new EventHandler(btnFilter_onClick);
        }
        public bool CreateOpeningBalancesProduct(int stock, Guid productId)
        {
            // رصيد افتتاحي
            return true;
        }
        private void OnCLickSearchbtn(object sender, EventArgs e)
        {
            if (_view.ActiveProduct.SelectedIndex != -1)
            {
                _view.SearchResult.DataSource = GetAllProductStockDetailsByDateTime(_view.StartDate.Value, _view.EndDate.Value,
                    _view.ProcessType.Text, new Guid(_view.ActiveProduct.SelectedValue.ToString()));

            }
        }
        public List<ProductStockDetails> GetAllProductStockDetails()
        {
            var AllProductStock = ProductStock.GetAllProductStockDetails();
            if (AllProductStock != null)
                return AllProductStock;
            return null;
        }
        public List<ProductStockDetails> GetAllProductStockDetailsByDateTime(DateTime? firstDateTime, DateTime? lastDateTime, string orderType, Guid? productId)
        {
            var AllProductStock = ProductStock.GetAllProductStockDetailsByDateTime(firstDateTime, lastDateTime, orderType, productId);
            if (AllProductStock != null)
                return AllProductStock;
            return null;
        }
        // Filter By Barcode All order type all time
        private void btnFilter_onClick(object sender, EventArgs e)
        {
            FilterBy();
        }
        public void FilterBy()
        {
            if (!string.IsNullOrEmpty(_view.Search.Text))
            {
                string barcode = _view.ProductBarCode.Text;
                var FilterByBarcode = ProductStock.GetAllProductStockDetails().Where(d => d.ProductNumber == long.Parse(barcode)
                || d.BarCode == long.Parse(barcode));
                if (_view.ProcessType.SelectedIndex != -1)
                {
                    FilterByBarcode = ProductStock.GetAllProductStockDetails().Where(d => d.ProductNumber == long.Parse(barcode)
                    || d.BarCode == long.Parse(barcode) 
                    && d.OrderType == "مبيعات");
                    _view.SearchResult.DataSource = FilterByBarcode.ToList();
                }
                //_view.SearchResult.DataSource = FilterByBarcode.ToList();
            }
            else
            {
                return;
            }
        }
        internal void OnLoad()
        {
            PopulateActiveProduct.PopulateProducts(_view.ActiveProduct);
        }
    }
}
