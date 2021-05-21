using ElbayaNPresentation.Presenters.CommonPresenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Employees.Employees;
using ElbayanServices.Repository.Products.Product;
using ElbayaNPresentation.Views.Client;
using Guna.UI2.WinForms;
using ProductDto = ElbayanServices.Repository.Products.Product.Dtos.ProductDto;
using ElbayaNPresentation.Views.Purchases;
using ElbayanServices.Repository.Suppliers.OrderProcurement.Dtos;

namespace ElbayaNPresentation.Presenters.Orders
{
    public class PresenterOrder : IPresenterOrder
    {
        private readonly ProductService Product = new ProductService(new ConnectionOption());
        private readonly EmployeeService User = new EmployeeService(new ConnectionOption());

        public void FillProduct(ComboBox cbxProduct)
        {
            PopulateActiveProduct.PopulateProducts(cbxProduct);
        }
        public void AddProductToDGV(Guid ID, DataGridView OrderProduct, decimal LastPrice)
        {
            var model = Product.GetById(ID);
            GetProduct(model, OrderProduct, LastPrice);
        }
        private void ValidateTextBarcodeInput(Guna2TextBox BareCode)
        {
            if (string.IsNullOrWhiteSpace(BareCode.Text) || string.IsNullOrEmpty(BareCode.Text))
            {
                MessageBox.Show(" يجب ادخال رقم منتج أو باركود الشركة أو باركود دولي صحيح", "تأكيد");
                return;
            }
            if (BareCode.Text.Trim() == string.Empty || BareCode.Text.Trim().Length < 0)
            {
                MessageBox.Show("يجب ادخال رقم منتج أو باركود الشركة أو باركود دولي  صحيح", "تأكيد");
                return;
            }
        }
        // rtuern ProdcuDTo
        public ProductDto GetProductID(Guna2TextBox BareCode)
        {
            ValidateTextBarcodeInput(BareCode);
            long? Barcode = NullableNumber.BarecodeNumber(BareCode.Text);
            int? PSNumber = NullableNumber.ProductNumber(BareCode.Text);
            int? UCP = NullableNumber.ProductNumber(BareCode.Text);
            var model = Product.GetProductByBarcodeOrProductNumber(Barcode, PSNumber, UCP);

            return model;

        }
        public void AddProductToDGVbtn(Guid ID, DataGridView OrderProduct, decimal LastPrice)
        {
            var model = Product.GetById(ID);
            GetProduct(model, OrderProduct, LastPrice);
        }
        public virtual void cbxSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
        public void DeleteFromDGV(DataGridView OrderProduct)
        {
            if (OrderProduct.Rows.Count >= 1)
            {
                if (OrderProduct.SelectedRows.Count > 0)
                {
                    int currentRow = OrderProduct.SelectedRows[0].Index;
                    OrderProduct.Rows.RemoveAt(currentRow);
                    SelectLastRow(OrderProduct);
                }
            }
        }
        public void GetProduct(ProductDto model, DataGridView OrderProduct, decimal LastPrice)
        {
            if (model != null)
            {
                var index = OrderProduct.Rows.Add();
                OrderProduct.Rows[index].Cells["OrderProductId"].Value = model.Id.ToString();
                OrderProduct.Rows[index].Cells["PSNumber"].Value = model.ProductNumber;
                OrderProduct.Rows[index].Cells["ProductName"].Value = model.Name;
                OrderProduct.Rows[index].Cells["Unit"].Value = model.IsMAinSalesUnit;
                OrderProduct.Rows[index].Cells["LastPurchasePrice"].Value = LastPrice;

                // Quantity
                OrderProduct.Rows[index].Cells["Qunatity"].Value = 1;

                // Calulate PriceTOQuantity -> Quantity Price => Qunatity * Last Purchase price
                if (LastPrice == 0)
                {
                    LastPrice = model.PurchaseDefaultPrice;
                }
                decimal ProductPrice = LastPrice * Convert.ToDecimal(OrderProduct.Rows[index].Cells["Qunatity"].Value);
                OrderProduct.Rows[index].Cells["PriceTOQuantity"].Value = Math.Round(ProductPrice, 2);
                // Discount
                decimal DiscountValue = model.Discount / 100; // Get discount percent ex. 12% => 0.12
                // Calulate Product Discoun => ProductPrice - (Product Price * Discunt Value)
                decimal ProductDiscount = ProductPrice * DiscountValue;
                OrderProduct.Rows[index].Cells["Discount"].Value = Math.Round(ProductDiscount, 2);
                OrderProduct.Rows[index].Cells["DiscountPercent"].Value = Math.Round(model.Discount, 2);

                // Calualte VAT Value (Default Price + (Default Price * (Model.VAT / 100)))
                if (model.Vat > 0)
                {
                    decimal VATValue = model.Vat / 100; // convert Percent To Value
                    OrderProduct.Rows[index].Cells["VATPercent"].Value = model.Vat;
                    decimal CalulateVATValue = Math.Round(ProductPrice * VATValue, 2);
                    OrderProduct.Rows[index].Cells["VATValue"].Value = CalulateVATValue;
                    OrderProduct.Rows[index].Cells["Subtotal"].Value = Math.Round((ProductPrice - ProductDiscount) + CalulateVATValue, 2);
                }
                else
                {
                    OrderProduct.Rows[index].Cells["VATPercent"].Value = model.Vat;
                    OrderProduct.Rows[index].Cells["VATValue"].Value = "0.0";
                    OrderProduct.Rows[index].Cells["Subtotal"].Value = Math.Round((ProductPrice - ProductDiscount), 2);
                }
                SelectLastRow(OrderProduct);
            }
        }
        public void NewSupplier_OnCLick(object sender, EventArgs e)
        {
            frmNewSupplier.Instance.ShowDialog();
        }
        public void PopulateQualityEdit(DataGridView OrderProduct)
        {
            frmEditQuantity.Instance.txtQuantity.SelectAll();
            frmEditQuantity.Instance.txtQuantity.Select();
            int index = OrderProduct.SelectedRows[0].Index;
            frmEditQuantity.Instance.Quantity.Text = OrderProduct.Rows[index].Cells["Qunatity"].Value.ToString();
            frmEditQuantity.Instance.DefaultPrice.Text = OrderProduct.Rows[index].Cells["PriceTOQuantity"].Value.ToString();
            frmEditQuantity.Instance.Discount.Text = OrderProduct.Rows[index].Cells["DiscountPercent"].Value.ToString();

            frmEditQuantity.Instance.Subtotal.Text = Math.Round((Convert.ToDecimal(frmEditQuantity.Instance.Quantity.Text)
                * Convert.ToDecimal(frmEditQuantity.Instance.DefaultPrice.Text)), 2).ToString();
            // Calulate Discount = Subtotal - (SubTotal * (Discount / 100))
            decimal discount = (Convert.ToDecimal(frmEditQuantity.Instance.Subtotal.Text)
                * (Convert.ToDecimal(frmEditQuantity.Instance.Discount.Text) / 100));
            frmEditQuantity.Instance.TotalProductPrice.Text = Math.Round((Convert.ToDecimal(frmEditQuantity.Instance.Subtotal.Text) - discount), 3).ToString();
            // Calulate VAT => TotalProductPrice + (TotalProductPrice * (Product VAT))
            decimal VATPercent = Convert.ToDecimal(OrderProduct.Rows[index].Cells["VATPercent"].Value);
            if (VATPercent > 0)
            {
                frmEditQuantity.Instance.IsVatIncluded.Checked = true;
                decimal productVAT = Convert.ToDecimal(frmEditQuantity.Instance.TotalProductPrice.Text) * (VATPercent / 100);
                frmEditQuantity.Instance.VatValue.Text = Math.Round(productVAT, 2).ToString();
                frmEditQuantity.Instance.Vat = VATPercent / 100;
                frmEditQuantity.Instance.TotalWithVat.Text = Math.Round((Convert.ToDecimal(frmEditQuantity.Instance.TotalProductPrice.Text) + productVAT), 2).ToString();
            }
            else
            {
                frmEditQuantity.Instance.IsVatIncluded.Checked = false;
                frmEditQuantity.Instance.TotalWithVat.Text = Math.Round(Convert.ToDecimal(frmEditQuantity.Instance.TotalProductPrice.Text), 3).ToString();
                frmEditQuantity.Instance.VatValue.Text = "0.0";
            }
        }
        public string PopulateUser()
        {
            string user = User.GetById(new Guid("0B664256-3F93-EB11-84C5-80A5899D8326")).Name;
            return user;
        }
        public void PrintInvioce(Guid iD)
        {
            //
        }
        public void SelectLastRow(DataGridView OrderProduct)
        {
            if (OrderProduct.Rows.Count >= 1)
            {
                OrderProduct.ClearSelection();
                int nRowIndex = OrderProduct.Rows.Count - 1;
                OrderProduct.Rows[nRowIndex].Selected = true;
                OrderProduct.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            else
            {
                MessageBox.Show("لم يعد هنا صفوف منتجات");
            }
        }
    }
}
