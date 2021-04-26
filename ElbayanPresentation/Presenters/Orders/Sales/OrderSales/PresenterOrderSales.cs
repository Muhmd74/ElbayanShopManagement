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

namespace ElbayaNPresentation.Presenters.Sales.OrderSales
{
    public class PresenterOrderSales : PresenterOrder
    {
        private IViewOrderSale _view;
        private readonly OrderService SalesOrder = new OrderService(new ConnectionOption());
        private readonly CustomerService Customer = new CustomerService(new ConnectionOption());
        private readonly ProductService Product = new ProductService(new ConnectionOption());
        private readonly EmployeeService User = new EmployeeService(new ConnectionOption());

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
            _view.OrderNumber.Text = SalesOrder.GenerateSequenceNumberSupplier().ToString();

            PopulateClient(_view.Suppliers);

        }
        // Events Handler : 
        public void EventsHandlers()
        {
            _view.NewSupplier.Click += new EventHandler(NewSupplier_OnCLick);
            _view.DeleteProductFromOrder.Click += new EventHandler(DeleteFrombtn_OnClick);

            _view.Suppliers.SelectionChangeCommitted += new EventHandler(cbxSupplier_SelectionChangeCommitted);
            _view.BareCode.KeyDown += new KeyEventHandler(txtProductBarcode_KeyDown);
        }
        public override void cbxSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var model = Customer.GetCustomerById(new Guid(_view.Suppliers.SelectedValue.ToString()));
            _view.SupplierMobile.Text = model.Mobile.ToString();
        }
        // Form Functionality: 
        internal void txtProductBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F1)
            {
                var model = GetProductID(_view.BareCode);
                if (model != null)
                {
                    Guid ID = model.Id;
                    decimal lastSalsePrice = SalesOrder.GetLastProductPrice(ID);
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
        internal void DeleteFrombtn_OnClick(Object sender, EventArgs e)
        {

            DeleteFromDGV(_view.OrderProduct);
            if (_view.OrderProduct.Rows.Count <= 0)
            {
                _view.Paid.Text = "0.0";
            }
            ClaculateTotalOrderAmount();
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
        public void CreateClientOrder()
        {
            throw new NotImplementedException();
        }
        public void DeleteFromDGV(object sender, EventArgs e)
        {
            DeleteFromDGV(_view.OrderProduct);
            if (_view.OrderProduct.Rows.Count <= 0)
            {
                _view.Paid.Text = "0.0";
            }
            ClaculateTotalOrderAmount();
        }
        public List<OrderProductDto> GetOrderProducts()
        {
            throw new NotImplementedException();
        }
        public void GetProduct(ElbayanServices.Repository.Products.Product.Dtos.ProductDto model)
        {
            throw new NotImplementedException();
        }
        public void onPrintbtnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void PopulateQualityEdit()
        {
            throw new NotImplementedException();
        }
        public new void PrintInvioce(Guid iD)
        {
            throw new NotImplementedException();
        }
        public void ClearControl()
        {
            _view.OrderNumber.Text = SalesOrder.GenerateSequenceNumberSupplier().ToString();
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
