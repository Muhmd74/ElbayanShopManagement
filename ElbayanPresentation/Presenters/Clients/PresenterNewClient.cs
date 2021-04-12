using ElbayaNPresentation.Views.Client;
using ElbayaNPresentation.Views.Client.Suppliers;
using ElbayanServices.Repository.Clints.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void OnLoad()
        {
           _view.RefSupplierNumber.Text =  GenerateClientNumber();
            _view.SuppliersName.Select();
        }
        // CRUD:
        // 1. Create new Object:
        private string GenerateClientNumber()
        {
            long ClientNumber = Client.GenerateClientNumber();
            return ClientNumber.ToString();
        }
        public void OnClickbtnAddNewOpect()
        {
            if (!string.IsNullOrEmpty(_view.SuppliersName.Text) && !string.IsNullOrEmpty(_view.Mobile.Text))
            {
                if(MessageBox.Show("هل تود إضافة مورد جديد", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CreateCustomer();
                    ClearControls();
                }
                else
                {
                    CreateCustomer();
                    ClearControls();
                    ucAllSupplier.Instance.Presenter.OnLoadUC();
                    frmNewClient.Instance.Close();
                }
            }
            else
            {
                MessageBox.Show("إدخال اسم المورد ورقم جواله إلزامي", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }
        private void CreateCustomer()
        {
            Client.CreateCustomer(new ElbayanServices.Repository.Clints.Supplier.Dtos.ClintDto
            {
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
                OpeningBalance = Convert.ToInt32(_view.OpeningBalance.Value),
                FaxNumber = _view.Fax.Text,
                IsSupplier = _view.IsSupplier,
                IsCustomer = _view.IsCustomer,
                Phone = _view.FirmPhoneNumber.Text
            });
        }
       // 2. Update Current Object:
        private void UpdateClient()
        {
            Client.UpdateCustomer(new ElbayanServices.Repository.Clints.Supplier.Dtos.ClintDto
            {
                Id = _view.ID,
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
                OpeningBalance = Convert.ToInt32(_view.OpeningBalance.Value),
                FaxNumber = _view.Fax.Text,
                IsSupplier = _view.IsSupplier,
                IsCustomer = _view.IsCustomer,
                Phone = _view.FirmPhoneNumber.Text
            });
        }
        public void OnClickbtnUpdate()
        {
            if (!string.IsNullOrEmpty(_view.SuppliersName.Text) && !string.IsNullOrEmpty(_view.Mobile.Text))
            {
                if (MessageBox.Show("هل تود إضافة مورد جديد", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UpdateClient();
                    ClearControls();
                }
                else
                {
                    UpdateClient();
                    ClearControls();
                    frmNewClient.Instance.Close();
                }
            }
            else
            {
                MessageBox.Show("إدخال اسم المورد ورقم جواله إلزامي", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }
        internal void OnActiveChekedChanged()
        {
            if (_view.IsActive.Checked)
            {
                if (MessageBox.Show("هل تريد تحويل المورد إلى غير نشط", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    Client.ChangeActivity(_view.ID);
                    frmNewClient.Instance.Close();
                }
            }
            else
            {

            }
        }
        private void ClearControls()
        {
            _view.SuppliersName.Text = _view.IdentityNumber.Text = _view.FirmName.Text =
                _view.Address.Text = _view.TradeLicense.Text = _view.RefSupplierNumber.Text = _view.Note.Text =
                _view.Mobile.Text = _view.TaxNumber.Text = _view.Fax.Text = _view.FirmPhoneNumber.Text = 
                _view.Email.Text = "";
            
            _view.OpeningBalance.Value = 0m;
        }

    }
}
