using ElbayanServices.Repository.Clints.Customer;
using ElbayanServices.Repository.Clints.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Clients.Suppliers
{
    public class PresenterNewSupplier
    {
        private readonly IViewNewSupplier _view;
        private readonly SupplierService supplierService = new SupplierService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        private readonly CustomerService Client = new CustomerService(new ElbayanDatabase.ConnectionTools.ConnectionOption());


        public PresenterNewSupplier(IViewNewSupplier view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }
        public void OnLoad()
        {
            _view.RefSupplierNumber.Text = GenerateClientNumber();
            _view.SuppliersName.Select();
        }
        // CRUD:
        // 1. Create new Object:
        private string GenerateClientNumber()
        {
            long ClientNumber = Client.GenerateClientNumber();
            return ClientNumber.ToString();
        }
    }
}
