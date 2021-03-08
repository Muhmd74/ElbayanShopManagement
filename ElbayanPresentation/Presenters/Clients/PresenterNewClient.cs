using ElbayanServices.Repository.Clints.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Clients
{
    public class PresenterNewClient
    {
        private readonly IViewNewClient _view;
        private readonly CustomerService Client = new CustomerService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public PresenterNewClient(IViewNewClient view)
        {
            _view = view;
        }

        // CRUD:
        // 1. Create new Object:

        public void OnClickbtnAddNewOpect()
        {
            Client.CreateCustomer(new ElbayanServices.Repository.Clints.Supplier.Dtos.ClintDto { 
                Name = _view.SuppliersName.Text,
                NationalIdentity = Convert.ToInt32(_view.IdentityNumber.Text),
                IsActive = _view.IsActive.Checked,
                FirmName = _view.FirmName.Text,
                Address = _view.Address.Text,
                CommercialRegister = _view.TradeLicense.Text,
                ReferenceNumber = Convert.ToInt32(_view.RefSupplierNumber.Text),
                Description = _view.Note.Text,
                Mobile = _view.Mobile.Text,
                TaxNumber = _view.TaxNumber.Text,
                OpeningBalance = Convert.ToInt32( _view.OpeningBalance.Value),
                FaxNumber = _view.Fax.Text,
                IsSupplier = _view.IsSupplier,
                IsCustomer = _view.IsCustomer,
               //cv Phone = _view.
            });
        }
        

    }
}
