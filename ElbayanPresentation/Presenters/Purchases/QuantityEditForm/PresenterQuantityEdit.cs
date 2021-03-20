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
        private readonly ProductService Product = new ProductService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterQuantityEdit(IViewQuantityEdit view)
        {
            _view = view;
        }

        internal void OnLoad()
        {
            LoadDataFromDGV();
            //_view.Quantity.MaxLength = 12;
            //_view.DefaultPrice.MaxLength = 12;
            //_view.TotalProductPrice.MaxLength = 12;
            //_view.Discount.MaxLength = 12;
            //_view.Subtotal.MaxLength = 12;
            //_view.TotalWithVat.MaxLength = 12;
        }

        private void LoadDataFromDGV()
        {
            if (frmProcurementOrder.Intance.OrderProduct.Rows.Count > 1)
            {
                int index = frmProcurementOrder.Intance.dgvOrderProduct.SelectedRows[0].Index;
                var model = Product.GetById(new Guid(frmProcurementOrder.Intance.OrderProduct.Rows[index].Cells["OrderProductId"].Value.ToString()));
                _view.Vat = model.Vat;
                _view.Quantity.Text = frmProcurementOrder.Intance.OrderProduct.Rows[index].Cells["Qunatity"].Value.ToString();
                _view.DefaultPrice.Text = model.PurchaseDefaultPrice.ToString();
                _view.Subtotal.Text = Math.Round((Convert.ToDecimal(_view.Quantity.Text) * Convert.ToDecimal(_view.DefaultPrice.Text)), 3).ToString();
                _view.Discount.Text = model.Discount.ToString();

                // Calulate Discount = Subtotal - (SubTotal * (Discount / 100))

                decimal discount = (Convert.ToDecimal(_view.Subtotal.Text) * (Convert.ToDecimal(_view.Discount.Text) / 100));
                _view.TotalProductPrice.Text = Math.Round((Convert.ToDecimal(_view.Subtotal.Text) - discount), 3).ToString();

                // Calulate VAT => TotalProductPrice + (TotalProductPrice * (Product VAT))
                decimal productVAT = Convert.ToDecimal(_view.TotalProductPrice.Text) * (model.Vat / 100);

                if (model.Vat > 0)
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

                ClearControls();
            }
            else
            {
                MessageBox.Show("لا بد من إضافة منتجات أولا للفاتورة");
                return;
            }
        }

        internal void ClearControls()
        {
            _view.Quantity.Text = _view.DefaultPrice.Text = _view.Discount.Text = _view.VatValue.Text = _view.Subtotal.Text =
                _view.TotalProductPrice.Text = _view.TotalWithVat.Text = string.Empty;
            _view.IsVatIncluded.Checked = false;
        }

        internal void CalulateQuanity()
        {
            _view.Subtotal.Text = Math.Round((Convert.ToDecimal(_view.Quantity.Text) * Convert.ToDecimal(_view.DefaultPrice.Text)), 3).ToString();

            // Calulate Discount = Subtotal - (SubTotal * (Discount / 100))

            decimal discount = (Convert.ToDecimal(_view.Subtotal.Text) * (Convert.ToDecimal(_view.Discount.Text) / 100));
            _view.TotalProductPrice.Text = Math.Round((Convert.ToDecimal(_view.Subtotal.Text) - discount), 3).ToString();

            // Calulate VAT => TotalProductPrice + (TotalProductPrice * (Product VAT))
            decimal productVAT = Convert.ToDecimal(_view.TotalProductPrice.Text) * (_view.Vat / 100);

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

        internal void PopulateOrderProductUpdatedQuantity()
        {
            int index = frmProcurementOrder.Intance.OrderProduct.SelectedRows[0].Index;
            try
            {
                frmProcurementOrder.Intance.OrderProduct.Rows[index].Cells["Qunatity"].Value = _view.Quantity.Text;
                frmProcurementOrder.Intance.OrderProduct.Rows[index].Cells["PriceIncVat"].Value = _view.TotalProductPrice.Text;
                frmProcurementOrder.Intance.OrderProduct.Rows[index].Cells["Discount"].Value = _view.Discount.Text;
                frmProcurementOrder.Intance.OrderProduct.Rows[index].Cells["Subtotal"].Value = _view.TotalWithVat.Text;
            } catch (Exception){}
        }
    }
}
