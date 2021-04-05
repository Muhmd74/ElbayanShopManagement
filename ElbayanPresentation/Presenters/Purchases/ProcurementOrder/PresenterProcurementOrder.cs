using DevExpress.XtraReports.UI;
using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Reports;
using ElbayaNPresentation.Views.Client;
using ElbayaNPresentation.Views.Purchases;
using ElbayanServices.Repository.Clints.OrderProcurement;
using ElbayanServices.Repository.Clints.OrderProcurement.Dtos;
using ElbayanServices.Repository.Clints.Supplier;
using ElbayanServices.Repository.Employees.Employees;
using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.Product.Dtos;
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
            PopulateActiveProduct.PopulateProducts(_view.Products);
            _view.PrintOrder.Click += new EventHandler(onPrintbtnClick);
            
        }
        internal void OnLoad()
        {
            PopulateSuppliers();
            PopulateUser();
            _view.OrderNumber.Text = orderProcuremnt.GenerateSequenceNumberSupplier().ToString();
            
            _view.UserName.Text = User.GetById(new Guid("0B664256-3F93-EB11-84C5-80A5899D8326")).Name;
        }
        internal void PopulateUser()
        {
            var user = User.GetById(new Guid("7b706e91-4784-eb11-84c2-80a5899d8326"));
            //_view.UserName.Text = user.Name;
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
                    var newOrder = orderProcuremnt.CreateSupplierOrder(new OrderDto
                    {
                        EmployeeId = new Guid("0B664256-3F93-EB11-84C5-80A5899D8326"),
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
                        PosId = new Guid("AA552BAA-2890-EB11-84C5-80A5899D8326"),
                    });
                    _view.ID = newOrder;
                    //PrintInvioce(_view.ID);
                    ClearControl();
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
        private void PrintInvioce(Guid iD)
        {
            var ds = orderProcuremnt.PrintInvoice(iD);
            rptOrderPurchase.PrintOrder(ds);
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
                    Discount = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Discount"].Value.ToString()),
                    PriceSale = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value.ToString()),
                    Quantity = Convert.ToInt32(_view.OrderProduct.Rows[i].Cells["Qunatity"].Value),
                    SubTotalPrice = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Qunatity"].Value.ToString()) *
                                     Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value.ToString()),
                    TotalPrice = (Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Qunatity"].Value.ToString()) *
                                     Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value.ToString()))
                                     + Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["VATValue"].Value.ToString()),
                    TotalProductPrice = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Subtotal"].Value),
                    Vat = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["VATValue"].Value)
                };
                orderProducts.Add(orderProduct);
            }
            return orderProducts;


        }
        internal void PopulateQualityEdit()
        {
            frmEditQuantity.Instance.txtQuantity.SelectAll();
            frmEditQuantity.Instance.txtQuantity.Select();
            int index = _view.OrderProduct.SelectedRows[0].Index;
            frmEditQuantity.Instance.Quantity.Text = "1";
            frmEditQuantity.Instance.DefaultPrice.Text = _view.OrderProduct.Rows[index].Cells["LastPurchasePrice"].Value.ToString();
            frmEditQuantity.Instance.Discount.Text = _view.OrderProduct.Rows[index].Cells["DiscountPercent"].Value.ToString();

            frmEditQuantity.Instance.Subtotal.Text = Math.Round((Convert.ToDecimal(frmEditQuantity.Instance.Quantity.Text)
                * Convert.ToDecimal(frmEditQuantity.Instance.DefaultPrice.Text)), 2).ToString();
            // Calulate Discount = Subtotal - (SubTotal * (Discount / 100))
            decimal discount = (Convert.ToDecimal(frmEditQuantity.Instance.Subtotal.Text)
                * (Convert.ToDecimal(frmEditQuantity.Instance.Discount.Text) / 100));
            frmEditQuantity.Instance.TotalProductPrice.Text = Math.Round((Convert.ToDecimal(frmEditQuantity.Instance.Subtotal.Text) - discount), 3).ToString();
            // Calulate VAT => TotalProductPrice + (TotalProductPrice * (Product VAT))
            decimal VATPercent = Convert.ToDecimal(_view.OrderProduct.Rows[index].Cells["VATPercent"].Value);


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
            GetProduct(model);
        }
        internal void DeleteFromDGV()
        {
            if (_view.OrderProduct.Rows.Count >= 1)
            {
                if (_view.OrderProduct.SelectedRows.Count > 0)
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
            GetProduct(model);
        }
        private void GetProduct(ElbayanServices.Repository.Products.Product.Dtos.ProductDto model)
        {
            if (model != null)
            {
                decimal LastPurchasePrice = orderProcuremnt.GetLastProductPrice(model.Id);
                var index = _view.OrderProduct.Rows.Add();
                _view.OrderProduct.Rows[index].Cells["OrderProductId"].Value = model.Id.ToString();
                _view.OrderProduct.Rows[index].Cells["PSNumber"].Value = model.ProductNumber;
                _view.OrderProduct.Rows[index].Cells["ProductName"].Value = model.Name;
                _view.OrderProduct.Rows[index].Cells["Unit"].Value = model.IsMAinSalesUnit;
                _view.OrderProduct.Rows[index].Cells["LastPurchasePrice"].Value = LastPurchasePrice;

                // Quantity
                _view.OrderProduct.Rows[index].Cells["Qunatity"].Value = 1;

                // Calulate PriceTOQuantity -> Quantity Price => Qunatity * Last Purchase price
                if (LastPurchasePrice == 0)
                {
                    LastPurchasePrice = model.PurchaseDefaultPrice;
                }
                decimal ProductPrice = LastPurchasePrice * Convert.ToDecimal(_view.OrderProduct.Rows[index].Cells["Qunatity"].Value);
                _view.OrderProduct.Rows[index].Cells["PriceTOQuantity"].Value = Math.Round(ProductPrice, 2);
                // Discount
                decimal DiscountValue = model.Discount / 100; // Get discount percent ex. 12% => 0.12
                // Calulate Product Discoun => ProductPrice - (Product Price * Discunt Value)
                decimal ProductDiscount = ProductPrice * DiscountValue;
                _view.OrderProduct.Rows[index].Cells["Discount"].Value = Math.Round(ProductDiscount, 2);
                _view.OrderProduct.Rows[index].Cells["DiscountPercent"].Value = Math.Round(model.Discount, 2);

                // Calualte VAT Value (Default Price + (Default Price * (Model.VAT / 100)))
                if (model.Vat > 0)
                {
                    decimal VATValue = model.Vat / 100; // convert Percent To Value
                    _view.OrderProduct.Rows[index].Cells["VATPercent"].Value = model.Vat;
                    decimal CalulateVATValue = Math.Round(ProductPrice * VATValue, 2);
                    _view.OrderProduct.Rows[index].Cells["VATValue"].Value = CalulateVATValue;
                    _view.OrderProduct.Rows[index].Cells["Subtotal"].Value = Math.Round((ProductPrice - ProductDiscount) + CalulateVATValue, 2);
                }
                else
                {
                    _view.OrderProduct.Rows[index].Cells["VATPercent"].Value = model.Vat;
                    _view.OrderProduct.Rows[index].Cells["VATValue"].Value = "0.0";
                    _view.OrderProduct.Rows[index].Cells["Subtotal"].Value = Math.Round((ProductPrice - ProductDiscount), 2);
                }
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
                    decimal PriceQauntity = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value)
                        * Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Qunatity"].Value);
                    TotalOrderWithoutDiscount += PriceQauntity;
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
            _view.Suppliers.SelectedIndex = -1;
            _view.Products.SelectedIndex = -1;
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
        private void onPrintbtnClick(object sender, EventArgs e)
        {
            if(_view.ID != null)
            {
                PrintInvioce(_view.ID);
            }
            else
            {
                MessageBox.Show("لا بد من حفظ الفاتورة أولا ");
            }
        }
    }
}
