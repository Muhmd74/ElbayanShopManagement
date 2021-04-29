using ElbayanServices.Repository.Suppliers.SupplierMovement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Clients.Suppliers.SupplierDebit
{
    public class PresenterSupplierDebit
    {
        private readonly IViewSupplierDebit _view;
        private readonly SupplierMovementService _supplierMovement = new SupplierMovementService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterSupplierDebit(IViewSupplierDebit view)
        {
            _view = view;
        }

        internal void OnLoad()
        {
            _view.SuppliersMovementList.DataSource = _supplierMovement.GetAllSupplierMovement();
        }
    }
}
