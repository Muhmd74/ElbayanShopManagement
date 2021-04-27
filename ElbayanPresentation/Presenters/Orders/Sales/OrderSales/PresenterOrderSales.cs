using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Presenters.Orders;
using ElbayanServices.Repository.Clints.Customer;
using ElbayanServices.Repository.Clints.Orders;
using ElbayanServices.Repository.Employees.Employees;
using ElbayanServices.Repository.Products.Product;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ElbayanServices.Repository.Suppliers.OrderProcurement.Dtos;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Clints.Orders.Dtos;

namespace ElbayaNPresentation.Presenters.Sales.OrderSales
{
    public class PresenterOrderSales : PresenterOrder
    {
        private IViewOrderSale _view;
        private readonly OrderService _salesOrder = new OrderService(new ConnectionOption());
        private readonly CustomerService Customer = new CustomerService(new ConnectionOption());
        private readonly ProductService Product = new ProductService(new ConnectionOption());
        public PresenterOrderSales(IViewOrderSale view)
        {
            _view = view;
            EventsHandlers();

        }
        // Load Data :
        public void OnLoad()
        {
            FillProduct(_view.Products);
            _view.UserName.Text = PopulateUser();
            _view.OrderNumber.Text = _salesOrder.GenerateSequenceNumberSupplier().ToString();
            PopulateActiveClients.PopulateCustomers(_view.Suppliers);
            // Date Time . Now
            _view.OrderDate.Value = DateTime.Now;
            _view.OrderDeferredDate.Value = DateTime.Now;
        }
        // Events Handler : 
        public void EventsHandlers()
        {
            _view.NewSupplier.Click += new EventHandler(NewSupplier_OnCLick);
            _view.Suppliers.SelectionChangeCommitted += new EventHandler(cbxSupplier_SelectionChangeCommitted);
            _view.DeleteProductFromOrder.Click += new EventHandler(DeleteFrombtn_OnClick);
            _view.AddNewProductDGV.Click += new EventHandler(btnAddToDGV_OnClick);
            _view.BareCode.KeyDown += new KeyEventHandler(txtProductBarcode_KeyDown);
        }
        // Form Functionality: 
        public override void cbxSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var model = Customer.GetCustomerById(new Guid(_view.Suppliers.SelectedValue.ToString()));
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
            if (_view.Products.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار منتج", "تأكيد");
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
                Guid ID = model.Id;
                decimal lastPurchasePrice = _salesOrder.GetLastProductPrice(ID);
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
                    decimal lastSalsePrice = _salesOrder.GetLastProductPrice(ID);
                    if (lastSalsePrice == 0)
                    {
                        lastSalsePrice = model.SaleDefaultPrice;
                        AddProductToDGV(ID, _view.OrderProduct, lastSalsePrice);
                    }
                    else
                    {
                        AddProductToDGV(ID, _view.OrderProduct, lastSalsePrice);
                    }
                    ClaculateTotalOrderAmount();
                }
                else
                {
                    MessageBox.Show("يجب ادخال رقم منتج صحيح", "تأكيد");
                    return;
                }

            }
        }
        private Guid CreateSalesOrder()
        {
            var NewOrder = _salesOrder.CreateCustomerOrder(new ElbayanServices.Repository.Clints.Orders.Dtos.OrderCustomerDto()
            {
                EmployeeId = new Guid("0B664256-3F93-EB11-84C5-80A5899D8326"),
                IsDeferred = _view.IsDeferred.Checked,
                Deferred = Convert.ToDecimal(_view.Deferred.Text),
                DateTime = _view.OrderDate.Value,
                Payment = Convert.ToDecimal(_view.Paid.Text),
                OrderNumber = long.Parse(_view.OrderNumber.Text),
                ClintId = new Guid(_view.Suppliers.SelectedValue.ToString()),
                DueDatePayingOff = _view.OrderDeferredDate.Value,
                PaymentPerMonth = 150m, // For installment
                OrderProductDto = GetOrderProducts(),
                TotalDiscount = Convert.ToDecimal(_view.TotalOrderDiscount.Text),
                SubTotalWithoutDiscount = Convert.ToDecimal(_view.TotalOrderWithoutDiscount.Text),
                TotalAfterDiscount = Convert.ToDecimal(_view.TotalOrderWithDiscount.Text),
                PosId = new Guid("AA552BAA-2890-EB11-84C5-80A5899D8326"),
            });
            return NewOrder;
        }
     public void CreateClientOrder()
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
                        _view.ID = CreateSalesOrder();
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
        private List<OrderProductCustomerDto> GetOrderProducts()
        {
            List<OrderProductCustomerDto> OrderProducts = new List<OrderProductCustomerDto>();
            for (int i = 0; i <= _view.OrderProduct.Rows.Count - 1; i++)
            {
                var Product = new OrderProductCustomerDto()
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
                OrderProducts.Add(Product);
            }

            return OrderProducts;

        }
        public void onPrintbtnClick(object sender, EventArgs e)
        {
            //
        }
        public void ClaculateTotalOrderAmount()
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
        public void ClearControl()
        {
            _view.OrderNumber.Text = _salesOrder.GenerateSequenceNumberSupplier().ToString();
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