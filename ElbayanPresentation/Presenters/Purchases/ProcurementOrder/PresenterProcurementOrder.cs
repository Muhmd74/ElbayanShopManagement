using ElbayaNPresentation.Views.Client;
using ElbayanServices.Repository.Clints.OrderProcurement;
using ElbayanServices.Repository.Clints.Supplier;
using ElbayanServices.Repository.Products.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Purchases.ProcurementOrder
{
    public class PresenterProcurementOrder
    {
        private readonly IViewProcurementOrder _view;
        private readonly OrderProcurementService orderProcuremnt = new OrderProcurementService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        private readonly SupplierService Supplier = new SupplierService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        private readonly ProductService Product = new ProductService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterProcurementOrder(IViewProcurementOrder view)
        {
            _view = view;
        }

        internal void OnLoad()
        {
            PopulateSuppliers();
            PopulateProducts();
        }

        private void PopulateProducts()
        {
            _view.Products.DataSource = Product.GetAll();
            _view.Products.DisplayMember = "Name";
            _view.Products.ValueMember = "Id";
            _view.Products.SelectedValue = "Id";

        }

        private void PopulateSuppliers()
        {
            _view.Suppliers.DataSource = Supplier.GetAllSupplier();
            _view.Suppliers.DisplayMember = "Name";
            _view.Suppliers.ValueMember = "Id";
            _view.Suppliers.SelectedValue = "Id";
        }

        internal void NewSupplier_OnCLick()
        {
            frmNewClient.Instance.ShowDialog();
        }
    }
}
