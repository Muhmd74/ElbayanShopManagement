using ElbayanServices.Repository.Customers.Suppliers.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Purchases.Suppliers.SuplliersData
{
    public class PresenterSupplierData
    {
        private readonly IViewSuppleirData _view;
        private readonly SupplierService supplierService = new SupplierService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public PresenterSupplierData(IViewSuppleirData view)
        {
            _view = view;
        }
    }
}
