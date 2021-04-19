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

            var customer = Customer.GetAllCustomer();
            PopulateClient(customer, _view.Suppliers);

        }
        // Events Handler : 
        public void EventsHandlers()
        {
            _view.NewSupplier.Click += new EventHandler(NewSupplier_OnCLick);
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
                //AddProductToDGV(_view.BareCode);
            }
        }
        public void ClaculateTotalOrderAmount()
        {
            throw new NotImplementedException();
        }
        public void ClearControl()
        {
            throw new NotImplementedException();
        }
        public void CreateClientOrder()
        {
            throw new NotImplementedException();
        }
        public void DeleteFromDGV()
        {
            throw new NotImplementedException();
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
        public void SelectLastRow()
        {
            throw new NotImplementedException();
        }
    }
}
