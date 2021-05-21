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

                decimal discountValue = (Convert.ToDecimal(_view.Discount.Text) / 100);
                decimal discount = Math.Round(Convert.ToDecimal(_view.Subtotal.Text) * discountValue, 2);
                _view.DiscountValue.Text = Math.Round(discount, 2).ToString();

                _view.TotalProductPrice.Text = Math.Round((Convert.ToDecimal(_view.Subtotal.Text) - Convert.ToDecimal(_view.DiscountValue.Text)), 2).ToString();
                // Calulate VAT => TotalProductPrice + (TotalProductPrice * (Product VAT))
                if (Convert.ToDecimal(_view.VatValue.Text) > 0)
                {
                    decimal productVAT = Convert.ToDecimal(_view.TotalProductPrice.Text) * _view.Vat;
                    _view.VatValue.Text = Math.Round(productVAT, 2).ToString();
                    _view.TotalWithVat.Text = Math.Round((Convert.ToDecimal(_view.TotalProductPrice.Text) + productVAT), 2).ToString();
                }
                else
                {
                    _view.TotalWithVat.Text = Math.Round(Convert.ToDecimal(_view.TotalProductPrice.Text), 2).ToString();
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
            if(_view.IsPurchase == true)
            {
                int index = frmOrderPurchase.Intance.OrderProduct.SelectedRows[0].Index;
                frmOrderPurchase.Intance.dgvOrderProduct.Rows[index].Cells["Qunatity"].Value = _view.Quantity.Text;
                frmOrderPurchase.Intance.dgvOrderProduct.Rows[index].Cells["PriceTOQuantity"].Value = _view.Subtotal.Text;
                frmOrderPurchase.Intance.dgvOrderProduct.Rows[index].Cells["Discount"].Value = _view.DiscountValue.Text;
                decimal VatValuetxt = Convert.ToDecimal(_view.VatValue.Text);
                int VATValue = Convert.ToInt32(VatValuetxt);
                frmOrderPurchase.Intance.dgvOrderProduct.Rows[index].Cells["VATValue"].Value = VATValue;
                frmOrderPurchase.Intance.dgvOrderProduct.Rows[index].Cells["Subtotal"].Value = _view.TotalWithVat.Text;

                frmOrderPurchase.Intance.Presenter.ClaculateTotalOrderAmount();
                frmOrderPurchase.Intance.Presenter.SelectLastRow(frmOrderPurchase.Intance.dgvOrderProduct);
            }
            else
            {
                int index = frmOrderSales.Intance.OrderProduct.SelectedRows[0].Index;
                frmOrderSales.Intance.dgvOrderProduct.Rows[index].Cells["Qunatity"].Value = _view.Quantity.Text;
                frmOrderSales.Intance.dgvOrderProduct.Rows[index].Cells["PriceTOQuantity"].Value = _view.DefaultPrice.Text;
                frmOrderSales.Intance.dgvOrderProduct.Rows[index].Cells["Discount"].Value = _view.DiscountValue.Text;
                decimal VatValuetxt = Convert.ToDecimal(_view.VatValue.Text);
                int VATValue = Convert.ToInt32(VatValuetxt);
                frmOrderSales.Intance.dgvOrderProduct.Rows[index].Cells["VATValue"].Value = VATValue;
                frmOrderSales.Intance.dgvOrderProduct.Rows[index].Cells["Subtotal"].Value = _view.TotalWithVat.Text;

                frmOrderSales.Intance.Presenter.ClaculateTotalOrderAmount();
                frmOrderSales.Intance.Presenter.SelectLastRow(frmOrderSales.Intance.dgvOrderProduct);
            }
        }
    }
}
