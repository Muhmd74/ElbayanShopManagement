using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Presenters.Orders;
using ElbayaNPresentation.Reports;
using ElbayanServices.Repository.Employees.Employees;
using ElbayanServices.Repository.Products.Product;
using System;
using System.Linq;
using System.Windows.Forms;
using ElbayanServices.Repository.Suppliers.OrderProcurement;
using ElbayanServices.Repository.Suppliers.OrderProcurement.Dtos;
using ElbayanServices.Repository.Suppliers.Supplier;
using ElbayaNPresentation.Presenters.CommonPresenter;
using System.Collections.Generic;

namespace ElbayaNPresentation.Presenters.Purchases.ProcurementOrder
{
    public class PresenterProcurementOrder : PresenterOrder
    {
        private readonly IViewProcurementOrder _view;
        private readonly OrderProcurementService orderProcuremnt = new OrderProcurementService(new ConnectionOption());
        private readonly SupplierService Supplier = new SupplierService(new ConnectionOption());
        private readonly ProductService Product = new ProductService(new ConnectionOption());
        private readonly EmployeeService User = new EmployeeService(new ConnectionOption());
        public PresenterProcurementOrder(IViewProcurementOrder view)
        {
            _view = view;
            EventHandler();

        }
        // Load Data :
        internal void OnLoad()
        {
            PopulateActiveClients.PopulateSuppliers(_view.Suppliers);
            _view.UserName.Text = PopulateUser();
            FillProduct(_view.Products);
            _view.OrderNumber.Text = orderProcuremnt.GenerateSequenceNumberSupplier().ToString();
            // Date Time . Now
            _view.OrderDate.Value = DateTime.Now;
            _view.OrderDeferredDate.Value = DateTime.Now;
        }
        // Event Handler : 
        void EventHandler()
        {
            _view.NewSupplier.Click += new EventHandler(NewSupplier_OnCLick);
            _view.Suppliers.SelectionChangeCommitted += new EventHandler(cbxSupplier_SelectionChangeCommitted);
            _view.DeleteProductFromOrder.Click += new EventHandler(DeleteFrombtn_OnClick);
            _view.AddNewProductDGV.Click += new EventHandler(btnAddToDGV_OnClick);
            _view.BareCode.KeyDown += new KeyEventHandler(txtProductBarcode_KeyDown);
            _view.PrintOrder.Click += new EventHandler(onPrintbtnClick);
        }
        public override void cbxSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var model = Supplier.GetSupplierById(new Guid(_view.Suppliers.SelectedValue.ToString()));
            _view.SupplierMobile.Text = model.Mobile.ToString();
        }
        internal void DeleteFrombtn_OnClick(Object sender, EventArgs e)
        {

            DeleteFromDGV(_view.OrderProduct);
            if (_view.OrderProduct.Rows.Count <= 0)
            {
                _view.Paid.Text = "0.0";
            }
            ClaculateTotalOrderAmount();
        }
        internal void btnAddToDGV_OnClick(object sender, EventArgs e)
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
            if (_view.Products.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار منتج", "تأكيد");
                return;
            }

            var model = Product.GetById(new Guid(_view.Products.SelectedValue.ToString()));
            if (model != null)
            {
                Guid ID = model.Id;
                decimal lastPurchasePrice = orderProcuremnt.GetLastProductPrice(ID);
                AddProductToDGVbtn(ID, _view.OrderProduct, lastPurchasePrice);
                ClaculateTotalOrderAmount();
            }
            else
            {
                MessageBox.Show("يجب ادخال رقم منتج صحيح", "تأكيد");
                return;
            }
        }
        internal void txtProductBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F1)
            {
                var model = GetProductID(_view.BareCode);
                if (model != null)
                {
                    Guid ID = model.Id;
                    decimal lastPurchasePrice = orderProcuremnt.GetLastProductPrice(ID);
                    AddProductToDGV(ID, _view.OrderProduct, lastPurchasePrice);
                    ClaculateTotalOrderAmount();
                }
                else
                {
                    MessageBox.Show("يجب ادخال رقم منتج صحيح", "تأكيد");
                    return;
                }

            }
        }
        internal void CreateClientOrder()
        {
            if (_view.OrderProduct.Rows.Count >= 1)
            {
                if (_view.Suppliers.SelectedIndex != -1)
                {
                    if (Convert.ToDecimal(_view.Deferred.Text) != 0 && _view.IsDeferred.Checked == false)
                    {
                        MessageBox.Show("كرما اختر الفاتورة أجل أو ادفع المبلغ كاملا");
                        return; 
                    }
                    else
                    {
                        _view.ID = CreatePorcurementOrder();
                        //PrintInvioce(_view.ID);
                        ClearControl();
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
        private Guid CreatePorcurementOrder()
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
                OrderProductDto = GetOrderProducts(_view.OrderProduct).ToList(),
                TotalDiscount = Convert.ToDecimal(_view.TotalOrderDiscount.Text),
                SubTotalWithoutDiscount = Convert.ToDecimal(_view.TotalOrderWithoutDiscount.Text),
                TotalAfterDiscount = Convert.ToDecimal(_view.TotalOrderWithDiscount.Text),
                PosId = new Guid("AA552BAA-2890-EB11-84C5-80A5899D8326"),
            });
            return newOrder;
        }
        public List<OrderProductDto> GetOrderProducts(DataGridView OrderProduct)
        {
            List<OrderProductDto> orderProducts = new List<OrderProductDto>();
            for (int i = 0; i <= OrderProduct.Rows.Count - 1; i++)
            {
                decimal subTotal = Convert.ToDecimal(OrderProduct.Rows[i].Cells["Qunatity"].Value.ToString()) *
                                     Convert.ToDecimal(OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value.ToString());
                decimal totalProduct = subTotal - Convert.ToDecimal(OrderProduct.Rows[i].Cells["Discount"].Value);
                var orderProduct = new OrderProductDto()
                {
                    ProductId = new Guid(OrderProduct.Rows[i].Cells["OrderProductId"].Value.ToString()),
                    ProductName = OrderProduct.Rows[i].Cells["ProductName"].Value.ToString(),
                    Quantity = Convert.ToInt32(OrderProduct.Rows[i].Cells["Qunatity"].Value),
                    PriceSale = Convert.ToDecimal(OrderProduct.Rows[i].Cells["PriceTOQuantity"].Value.ToString()),
                    Discount = Convert.ToDecimal(OrderProduct.Rows[i].Cells["Discount"].Value.ToString()),
                    SubTotalPrice = subTotal,
                    TotalProductPrice = totalProduct,
                    Vat = Convert.ToDecimal(OrderProduct.Rows[i].Cells["VATValue"].Value),
                    TotalPrice = totalProduct +
                                  Convert.ToDecimal(OrderProduct.Rows[i].Cells["VATValue"].Value),
                };
                orderProducts.Add(orderProduct);
            }
            return orderProducts;
        }
        private void onPrintbtnClick(object sender, EventArgs e)
        {
            if (_view.ID != null)
            {
                PrintInvioce(_view.ID);
            }
            else
            {
                MessageBox.Show("لا بد من حفظ الفاتورة أولا ");
                return;
            }
        }
        private new void PrintInvioce(Guid ID)
        {
            var ds = orderProcuremnt.PrintInvoice(ID);
            rptOrderPurchase.PrintOrder(ds);
        }
        internal void ClaculateTotalOrderAmount()
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
            _view.TotalOrderWithoutVAT.Text = Math.Round(TotalOrderWithDiscount - TotalVATValue, 2).ToString();
            decimal Paid = Convert.ToDecimal(_view.Paid.Text);
            _view.Deferred.Text = Math.Round(TotalOrderWithDiscount - Paid, 2).ToString();

        }
        internal void ClearControl()
        {
            _view.OrderNumber.Text = orderProcuremnt.GenerateSequenceNumberSupplier().ToString();
            _view.Suppliers.SelectedIndex = -1;
            _view.Products.SelectedIndex = -1;
            _view.BareCode.Clear();
            _view.BareCode.Select();
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
    }
}
