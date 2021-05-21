using ElbayanServices.Repository.Suppliers.OrderReturn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Orders.Purchases.PurchaseReturn
{
    public class PresenterPurchaseReturn
    {
        private readonly IViewPurchaseReturn _view;
        private readonly SupplierOrderReturnService _supplierOrderReturnService = new SupplierOrderReturnService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterPurchaseReturn(IViewPurchaseReturn view)
        {
           _view = view;
            EventHandler();
        }
        public void OnLoad()
        {
            _view.OrderProducts.DataSource = null;
            _view.OrderProducts.AutoGenerateColumns = false;
        }
        private void EventHandler()
        {
            _view.SearchText.KeyDown += new KeyEventHandler(TextboxSearch_KeyDown);
        }
        private void TextboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                long orderNumber = long.Parse(_view.SearchText.Text);
                var order = _supplierOrderReturnService.GetPurchaseOrderByOrderNumber(orderNumber);
                _view.OrderProducts.DataSource = order.OrderReturnProduct;
                _view.SupplierName.Text = order.SupplierName;
                _view.TotalOrder.Text = order.TotalAfterDiscount.ToString();
                _view.OrderPayment.Text = order.Payment.ToString();
                _view.OrderDeferred.Text = order.Deferred.ToString();
                _view.TotalOrderVAT.Text = CalculateVate().ToString();
            }
            
        }
        private decimal CalculateVate()
        {
            decimal CountVat = 0.0m;
            for (int i = 0; i < _view.OrderProducts.Rows.Count; i++)
            {
                CountVat += Convert.ToDecimal(_view.OrderProducts.Rows[i].Cells["VATValue"].Value);
            }
            return CountVat;
        }


    }
}
