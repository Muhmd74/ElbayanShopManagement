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
using System.Windows.Forms;

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
        public void btnFilter_onClick(object sender, EventArgs e)
        {
            ValiadateStartDateBeforeEndDate();
            GetAllByOrderType();
            GetProductPeriodByIdAndOrderType();
            FilterBy();
        }
        public void FilterBy()
        {
            if (!string.IsNullOrEmpty(_view.Search.Text))
            {
                if (_view.ProductBarCode.Text != string.Empty)
                {
                    if (_view.ProcessType.SelectedIndex != -1)
                    {
                        FilterByBarcodeandOrderType();
                    }
                    long? barcode = NullableNumber.BarecodeNumber(_view.ProductBarCode.Text);
                    var FilterByBarcode = ProductStock.GetAllProductStockDetails().Where(d => d.ProductNumber == barcode || d.BarCode == barcode);
                    _view.SearchResult.DataSource = FilterByBarcode.ToList();
                }

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
        private void ValiadateStartDateBeforeEndDate()
        {
            if (_view.EndDate.Value < _view.StartDate.Value)
            {
                MessageBox.Show("يجب أن يكون بداية المدة قبل نهاية المدة", "تأكيد", MessageBoxButtons.OK);
                _view.EndDate.Value = DateTime.Now;
                _view.StartDate.Value = DateTime.Now;
                return;
            }
        }
        private void GetAllByOrderType()
        {
            if (_view.ProcessType.SelectedIndex != -1)
            {
                _view.SearchResult.DataSource = ProductStock.GetAllProductStockDetailsByType(_view.ProcessType.Text);
            }
        }
        private void GetProductPeriodByIdAndOrderType()
        {
            if (_view.ActiveProduct.SelectedIndex != -1)
            {
                if (_view.ProcessType.SelectedIndex != -1)
                {
                    DateTime? firstDate = _view.EndDate.Value;
                    DateTime? lastDate = _view.StartDate.Value;
                    string orderType = _view.ProcessType.Text;
                    Guid? ProductId = new Guid(_view.ActiveProduct.SelectedValue.ToString());
                    _view.SearchResult.DataSource = ProductStock.GetAllProductStockDetailsByDateTime(firstDate, lastDate, orderType, ProductId);
                }
            }
        }
        private void FilterByBarcodeandOrderType()
        {
            string orderType = _view.ProcessType.Text;
            long? barcode = NullableNumber.BarecodeNumber(_view.ProductBarCode.Text);
            var FilterByBarcodeandOrderType = ProductStock.GetAllProductStockDetails().Where(d => d.ProductNumber == barcode || d.BarCode == barcode
            && d.OrderType == orderType);
            _view.SearchResult.DataSource = FilterByBarcodeandOrderType.ToList();
        }
    }
}
