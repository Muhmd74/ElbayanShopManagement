using ElbayaNPresentation.Views.Purchases.Procurement;
using ElbayanServices.Repository.Products.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Purchases.QuantityEditForm
{
    public class PresenterQuantityEdit
    {
        private IViewQuantityEdit _view;
        public PresenterQuantityEdit(IViewQuantityEdit view)
        {
            _view = view;
        }
        internal void OnLoad()
        {

        }
        internal void ClearControls()
        {
            _view.Quantity.Text = _view.DefaultPrice.Text = _view.Discount.Text = _view.VatValue.Text = _view.Subtotal.Text =
                _view.TotalProductPrice.Text = _view.TotalWithVat.Text = string.Empty;
            _view.IsVatIncluded.Checked = false;
        }
        internal void CalulateQuanity()
        {
            if (_view.Quantity.Text.Trim() == string.Empty || _view.Quantity.Text.Trim().Length < 0
                || _view.DefaultPrice.Text.Trim() == string.Empty || _view.DefaultPrice.Text.Trim().Length < 0)
            {
                MessageBox.Show("الكمية  والسعر لا يمكن أن تكون فارغة");
                _view.Quantity.Text = "1";
                _view.DefaultPrice.Text = "1";
                return;
            }
            if (!string.IsNullOrEmpty(_view.Quantity.Text) || !string.IsNullOrWhiteSpace(_view.Quantity.Text)
                || !string.IsNullOrWhiteSpace(_view.DefaultPrice.Text) || !string.IsNullOrEmpty(_view.DefaultPrice.Text))
            {
                _view.Subtotal.Text = Math.Round((Convert.ToDecimal(_view.Quantity.Text) * Convert.ToDecimal(_view.DefaultPrice.Text)), 3).ToString();

                // Calulate Discount = Subtotal - (SubTotal * (Discount / 100))

                decimal discount = (Convert.ToDecimal(_view.Subtotal.Text) * (Convert.ToDecimal(_view.Discount.Text) / 100));
                _view.TotalProductPrice.Text = Math.Round((Convert.ToDecimal(_view.Subtotal.Text) - discount), 3).ToString();

                // Calulate VAT => TotalProductPrice + (TotalProductPrice * (Product VAT))
                decimal productVAT = Convert.ToDecimal(_view.Subtotal.Text) * (_view.Vat / 100);

                if (_view.Vat > 0)
                {
                    _view.IsVatIncluded.Checked = true;
                    _view.VatValue.Text = Math.Round(productVAT, 3).ToString();
                    _view.TotalWithVat.Text = Math.Round((Convert.ToDecimal(_view.TotalProductPrice.Text) + productVAT), 3).ToString();
                }
                else
                {
                    _view.IsVatIncluded.Checked = true;
                    _view.TotalWithVat.Text = Math.Round(Convert.ToDecimal(_view.TotalProductPrice.Text), 3).ToString();
                }
            }
            else
            {
                MessageBox.Show("الكمية  والسعر لا يمكن أن تكون فارغة");
                _view.Quantity.Text = "1";
                _view.DefaultPrice.Text = "1";
                return;
            }
        }
        internal void PopulateOrderProductUpdatedQuantity()
        {
            //int index = frmProcurementOrder.Intance.OrderProduct.SelectedRows[0].Index;

            try
            {
                frmProcurementOrder.Intance.OrderProduct.CurrentRow.Cells["Qunatity"].Value = _view.Quantity.Text;
                frmProcurementOrder.Intance.OrderProduct.CurrentRow.Cells["PriceIncVat"].Value = _view.TotalProductPrice.Text;
                frmProcurementOrder.Intance.OrderProduct.CurrentRow.Cells["Discount"].Value = _view.Discount.Text;
                frmProcurementOrder.Intance.OrderProduct.CurrentRow.Cells["Subtotal"].Value = _view.TotalWithVat.Text;
            }
            catch (Exception) { }
        }
    }
}
