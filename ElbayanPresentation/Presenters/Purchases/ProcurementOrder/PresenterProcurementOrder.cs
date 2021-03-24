using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Views.Client;
using ElbayaNPresentation.Views.Purchases;
using ElbayanServices.Repository.Clints.OrderProcurement;
using ElbayanServices.Repository.Clints.OrderProcurement.Dtos;
using ElbayanServices.Repository.Clints.Supplier;
using ElbayanServices.Repository.Employees.Employees;
using ElbayanServices.Repository.Products.Product;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Purchases.ProcurementOrder
{
    public class PresenterProcurementOrder
    {
        private readonly IViewProcurementOrder _view;
        private readonly OrderProcurementService orderProcuremnt = new OrderProcurementService(new ConnectionOption());
        private readonly SupplierService Supplier = new SupplierService(new ConnectionOption());
        private readonly ProductService Product = new ProductService(new ConnectionOption());
        private readonly EmployeeService User = new EmployeeService(new ConnectionOption());
        public PresenterProcurementOrder(IViewProcurementOrder view)
        {
            _view = view;
        }
        internal void OnLoad()
        {
            PopulateSuppliers();
            PopulateProducts();
            PopulateUser();
            _view.OrderNumber.Text = orderProcuremnt.GenerateSequenceNumberSupplier().ToString();
        }
        internal void PopulateUser()
        {
            var user = User.GetById(new Guid("7b706e91-4784-eb11-84c2-80a5899d8326"));
            _view.UserName.Text = user.Name;
        }
        private void PopulateProducts()
        {
            _view.Products.DisplayMember = "Name";
            _view.Products.ValueMember = "Id";
            _view.Products.SelectedValue = "Id";
            _view.Products.DataSource = Product.GetAll();
            _view.Products.SelectedIndex = -1;
        }
        private void PopulateSuppliers()
        {
            _view.Suppliers.DisplayMember = "Name";
            _view.Suppliers.ValueMember = "Id";
            _view.Suppliers.SelectedValue = "Id";
            var model = Supplier.GetAllSupplier();
            _view.Suppliers.DataSource = model;
            _view.Suppliers.SelectedIndex = -1;
        }
        internal void NewSupplier_OnCLick()
        {
            frmNewClient.Instance.ShowDialog();
        }
        internal void CreateSupplierOrder()
        {
            if (_view.OrderProduct.Rows.Count >= 1)
            {
                if (_view.Suppliers.SelectedIndex != -1)
                {
                    try
                    {
                        orderProcuremnt.CreateSupplierOrder(new OrderDto
                        {
                            EmployeeId = new Guid("7b706e91-4784-eb11-84c2-80a5899d8326"),
                            IsDeferred = _view.IsDeferred.Checked,
                            Deferred = Convert.ToDecimal(_view.Deferred.Text),
                            DateTime = _view.OrderDate.Value,
                            Payment = Convert.ToDecimal(_view.Paid.Text),
                            OrderNumber = long.Parse(_view.OrderNumber.Text),
                            ClintId = new Guid(_view.Suppliers.SelectedValue.ToString()),
                            DueDatePayingOff = _view.OrderDeferredDate.Value,
                            PaymentPerMonth = 150m,
                            OrderProductDto = GetOrderProducts().ToList(),
                            TotalDiscount = Convert.ToDecimal(_view.TotalOrderDiscount.Text),
                            SubTotalWithoutDiscount = Convert.ToDecimal(_view.TotalOrderWithoutDiscount.Text),
                            TotalAfterDiscount = Convert.ToDecimal(_view.TotalOrderWithDiscount.Text),
                            PosId = new Guid("90cd83b1-cf81-eb11-84c2-80a5899d8326"),

                        });
                        MessageBox.Show("DONE");
                        ClearControl();

                    }
                    catch (Exception)
                    {//MessageBox.Show(e.InnerException.Message);
                    }
                }
                else
                {
                    MessageBox.Show("كرما أختر مورد أولا");
                    return;
                }
            }
            else
            {
                MessageBox.Show("كرما أضف منتجات للفاتورة أولا");
                return;
            }
        }
        private List<OrderProductDto> GetOrderProducts()
        {
            List<OrderProductDto> orderProducts = new List<OrderProductDto>();
            for (int i = 0; i <= _view.OrderProduct.Rows.Count - 1; i++)
            {
                var orderProduct = new OrderProductDto()
                {
                    ProductId = new Guid(_view.OrderProduct.Rows[i].Cells["OrderProductId"].Value.ToString()),
                    ProductName = _view.OrderProduct.Rows[i].Cells["ProductName"].Value.ToString(),
                    Discount = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Discount"].Value),
                    PriceSale = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value),
                    SubTotalPrice = Convert.ToInt32(_view.OrderProduct.Rows[i].Cells["Qunatity"].Value) *
                                     Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value),
                    OrderId = _view.ID,
                    Quantity = Convert.ToInt32(_view.OrderProduct.Rows[i].Cells["Qunatity"].Value),
                    TotalPrice = (Convert.ToInt32(_view.OrderProduct.Rows[i].Cells["Qunatity"].Value) *
                                     Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value))
                                     + Convert.ToInt32(_view.OrderProduct.Rows[i].Cells["VATValue"].Value),
                    TotalProductPrice = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Subtotal"].Value),
                    Vat = Convert.ToInt32(_view.OrderProduct.Rows[i].Cells["VATValue"].Value)
                };
                orderProducts.Add(orderProduct);
            }
            return orderProducts;


        }
        internal void PopulateQualityEdit()
        {
            frmEditQuantity.Instance.txtQuantity.SelectAll();
            frmEditQuantity.Instance.txtQuantity.Select();
            //int index = _view.OrderProduct.CurrentRow.Index;
            var model = Product.GetById(new Guid(_view.OrderProduct.CurrentRow.Cells["OrderProductId"].Value.ToString()));
            frmEditQuantity.Instance.Quantity.Text = "1";
            frmEditQuantity.Instance.DefaultPrice.Text = model.PurchaseDefaultPrice.ToString();
            frmEditQuantity.Instance.Discount.Text = model.Discount.ToString();
            frmEditQuantity.Instance.Subtotal.Text = Math.Round((Convert.ToDecimal(frmEditQuantity.Instance.Quantity.Text)
                * Convert.ToDecimal(frmEditQuantity.Instance.DefaultPrice.Text)), 2).ToString();

            // Calulate Discount = Subtotal - (SubTotal * (Discount / 100))
            decimal discount = (Convert.ToDecimal(frmEditQuantity.Instance.Subtotal.Text)
                * (Convert.ToDecimal(frmEditQuantity.Instance.Discount.Text) / 100));
            frmEditQuantity.Instance.TotalProductPrice.Text = Math.Round((Convert.ToDecimal(frmEditQuantity.Instance.Subtotal.Text) - discount), 3).ToString();

            // Calulate VAT => TotalProductPrice + (TotalProductPrice * (Product VAT))
            decimal productVAT = Convert.ToDecimal(frmEditQuantity.Instance.TotalProductPrice.Text) * (model.Vat / 100);
            frmEditQuantity.Instance.Vat = model.Vat;
            if (model.Vat > 0)
            {
                frmEditQuantity.Instance.IsVatIncluded.Checked = true;
                frmEditQuantity.Instance.VatValue.Text = Math.Round(productVAT, 2).ToString();
                frmEditQuantity.Instance.TotalWithVat.Text = Math.Round((Convert.ToDecimal(frmEditQuantity.Instance.TotalProductPrice.Text) + productVAT), 3).ToString();
            }
            else
            {
                frmEditQuantity.Instance.IsVatIncluded.Checked = false;
                frmEditQuantity.Instance.TotalWithVat.Text = Math.Round(Convert.ToDecimal(frmEditQuantity.Instance.TotalProductPrice.Text), 3).ToString();
                frmEditQuantity.Instance.VatValue.Text = "0.0";
            }
        }
        internal void AddProductToDGV()
        {
            if (string.IsNullOrWhiteSpace(_view.BareCode.Text) || string.IsNullOrEmpty(_view.BareCode.Text))
            {
                MessageBox.Show(" يجب ادخال رقم منتج أو باركود الشركة أو باركود دولي صحيح", "تأكيد");
                return;
            }
            if (_view.BareCode.Text.Trim() == string.Empty || _view.BareCode.Text.Trim().Length < 0)
            {
                MessageBox.Show("يجب ادخال رقم منتج أو باركود الشركة أو باركود دولي  صحيح", "تأكيد");
                return;
            }
            long? Barcode = NullableNumber.BarecodeNumber(_view.BareCode.Text);
            int? PSNumber = NullableNumber.ProductNumber(_view.BareCode.Text);
            int? UCP = NullableNumber.ProductNumber(_view.BareCode.Text);
            PopulateProducttoDGVByID(Barcode, PSNumber, UCP);
        }
        internal void PopulateProducttoDGVByID(long? Barcode, int? PSNumber, int? UCP)
        {
            var model = Product.GetProductByBarcodeOrProductNumber(Barcode, PSNumber, UCP);
            if (model != null)
            {
                var index = _view.OrderProduct.Rows.Add();
                _view.OrderProduct.Rows[index].Cells["OrderProductId"].Value = model.Id.ToString();
                _view.OrderProduct.Rows[index].Cells["PSNumber"].Value = model.ProductNumber;
                _view.OrderProduct.Rows[index].Cells["ProductName"].Value = model.Name;
                _view.OrderProduct.Rows[index].Cells["Unit"].Value = model.IsMAinSalesUnit;
                // Quantity
                _view.OrderProduct.Rows[index].Cells["Qunatity"].Value = 1;

                // Calualte VAT Value (Default Price + (Default Price * (Model.VAT / 100)))
                decimal VATValue = model.Vat / 100; // convert Percent To Value
                // Calulate Price Include VAT => Quantity * Price Include VAT
                decimal ProductPrice = model.PurchaseDefaultPrice * Convert.ToDecimal(_view.OrderProduct.Rows[index].Cells["Qunatity"].Value);
                _view.OrderProduct.Rows[index].Cells["PriceTOQuantity"].Value = Math.Round(ProductPrice, 2);
                decimal CalulateVATValue = Math.Round(ProductPrice * VATValue, 2);
                _view.OrderProduct.Rows[index].Cells["VATValue"].Value = CalulateVATValue;
                // Discount
                decimal DiscountValue = model.Discount / 100; // Get discount Value ex. 12% => 0.12
                // Calulate Product Discoun => ProductPrice - (Product Price * Discunt Value)
                decimal ProductDiscount = ProductPrice * DiscountValue;
                _view.OrderProduct.Rows[index].Cells["Discount"].Value = Math.Round(ProductDiscount, 2);
                _view.OrderProduct.Rows[index].Cells["Subtotal"].Value = Math.Round((ProductPrice + CalulateVATValue) - ProductDiscount, 2);
                ClaculateTotalOrderAmount();
                SelectLastRow();
            }
        }
        internal void DeleteFromDGV()
        {
            if (_view.OrderProduct.Rows.Count >= 1)
            {
                if(_view.OrderProduct.SelectedRows.Count > 0)
                {
                    int currentRow = _view.OrderProduct.SelectedRows[0].Index;
                    _view.OrderProduct.Rows.RemoveAt(currentRow);
                    if (_view.OrderProduct.Rows.Count <= 0)
                    {
                        _view.Paid.Text = "0.0";
                    }
                    ClaculateTotalOrderAmount();
                    SelectLastRow();
                }
            }
        }
        internal void AddProductToDGVbtn()
        {
            if (_view.Products.Text == "أختر منتج")
            {
                MessageBox.Show("يجب يجب اختيار منتج", "تأكيد");
                return;
            }
            if (_view.Products.Items.Count <= 0)
            {
                MessageBox.Show("يجب اختيار منتج", "تأكيد");
                return;
            }
            var model = Product.GetById(new Guid(_view.Products.SelectedValue.ToString()));
            if (model != null)
            {
                var index = _view.OrderProduct.Rows.Add();
                _view.OrderProduct.Rows[index].Cells["OrderProductId"].Value = model.Id.ToString();
                _view.OrderProduct.Rows[index].Cells["PSNumber"].Value = model.ProductNumber;
                _view.OrderProduct.Rows[index].Cells["ProductName"].Value = model.Name;
                _view.OrderProduct.Rows[index].Cells["Unit"].Value = model.IsMAinSalesUnit;
                // Quantity
                _view.OrderProduct.Rows[index].Cells["Qunatity"].Value = 1;

                // Calualte VAT Value (Default Price + (Default Price * (Model.VAT / 100)))
                decimal VATValue = model.Vat / 100; // convert Percent To Value
                // Calulate Price Include VAT => Quantity * Price Include VAT
                decimal ProductPrice = model.PurchaseDefaultPrice * Convert.ToDecimal(_view.OrderProduct.Rows[index].Cells["Qunatity"].Value);
                _view.OrderProduct.Rows[index].Cells["PriceTOQuantity"].Value = Math.Round(ProductPrice, 2);
                decimal CalulateVATValue = Math.Round(ProductPrice * VATValue, 2);
                _view.OrderProduct.Rows[index].Cells["VATValue"].Value = CalulateVATValue;
                // Discount
                decimal DiscountValue = model.Discount / 100; // Get discount Value ex. 12% => 0.12
                // Calulate Product Discoun => ProductPrice - (Product Price * Discunt Value)
                decimal ProductDiscount = ProductPrice * DiscountValue;
                _view.OrderProduct.Rows[index].Cells["Discount"].Value = Math.Round(ProductDiscount, 2);
                _view.OrderProduct.Rows[index].Cells["Subtotal"].Value = Math.Round((ProductPrice + CalulateVATValue) - ProductDiscount, 2);
                ClaculateTotalOrderAmount();
                SelectLastRow();
            }
        }
        internal void ClaculateTotalOrderAmount()
        {
            try
            {

                decimal TotalOrderWithoutDiscount = 0;
                decimal TotalOrderDiscount = 0;
                decimal TotalOrderWithDiscount = 0;
                decimal TotalVATValue = 0;
                for (int i = 0; i <= _view.OrderProduct.Rows.Count - 1; i++)
                {
                    decimal PriceIncludeVAT = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value)
                        * Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Qunatity"].Value)
                        + Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["VATValue"].Value);
                    TotalOrderWithoutDiscount += PriceIncludeVAT;
                    TotalOrderDiscount += Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Discount"].Value);
                    TotalOrderWithDiscount += Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Subtotal"].Value);
                    TotalVATValue += Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["VATValue"].Value);
                }
                _view.TotalOrderWithoutDiscount.Text = Math.Round(TotalOrderWithoutDiscount, 2).ToString();
                _view.TotalOrderDiscount.Text = Math.Round(TotalOrderDiscount, 2).ToString();
                _view.TotalOrderWithDiscount.Text = Math.Round(TotalOrderWithDiscount, 2).ToString();
                _view.TotalOrderVAT.Text = Math.Round(TotalVATValue, 2).ToString();
                _view.TotalOrderWithoutVAT.Text = Math.Round(TotalOrderWithoutDiscount - TotalVATValue, 2).ToString();

                _view.Deferred.Text = Math.Round(TotalOrderWithDiscount - Convert.ToDecimal(_view.Paid.Text), 2).ToString();
            }
            catch (Exception) { }
        }
        internal void ClearControl()
        {
            _view.OrderNumber.Text = orderProcuremnt.GenerateSequenceNumberSupplier().ToString();
            _view.BareCode.Clear();
            _view.BareCode.Select();
            _view.Paid.Clear();
            _view.BareCode.Focus();
            _view.Suppliers.Text = "";
            _view.IsDeferred.Checked = false;
            _view.OrderDate.Value = DateTime.Now;
            _view.OrderDeferredDate.Value = DateTime.Now;
            _view.OrderProduct.Rows.Clear();
            _view.SupplierMobile.Clear();
            _view.TotalOrderDiscount.Text = _view.TotalOrderVAT.Text = _view.TotalOrderWithDiscount.Text =
                _view.TotalOrderWithoutDiscount.Text = _view.TotalOrderWithoutVAT.Text = _view.TotalOrderVAT.Text =
                _view.Paid.Text = _view.Deferred.Text = "0.0";
        }
        internal void SelectLastRow()
        {
            if (_view.OrderProduct.Rows.Count >= 1)
            {
                _view.OrderProduct.ClearSelection();
                int nRowIndex = _view.OrderProduct.Rows.Count - 1;
                _view.OrderProduct.Rows[nRowIndex].Selected = true;
                _view.OrderProduct.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            else
            {
                MessageBox.Show("لم يعد هنا صفوف منتجات");
            }
        }
        internal void OnSelectedValueChanged_SupplierMobile()
        {
            var model = Supplier.GetSupplierById(new Guid(_view.Suppliers.SelectedValue.ToString()));
            _view.SupplierMobile.Text = model.Mobile.ToString();
        }
    }
}
