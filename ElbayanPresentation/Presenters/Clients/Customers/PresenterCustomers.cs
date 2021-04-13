using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Views.Client;
using ElbayanServices.Repository.Clints.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Clients
{
    public class PresenterCustomers
    {
        private readonly IViewCustomers _view;
        private readonly CustomerService customerService = new CustomerService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public PresenterCustomers(IViewCustomers view)
        {
            _view = view;
            HandelEvents();
        }
        // Load Events:
        public void OnLoadUC()
        {
            DataGridViewStyle.StyleDatagridview(_view.ActiveObject);
            DataGridViewStyle.StyleDatagridview(_view.DeletedObject);

            //// Load Data Grid:
            PopualteActiveObjects();
            PopulateDeletedObject();
        }
        private void PopulateDeletedObject()
        {
            if (customerService.GetAllCustomerNotActive().Any())
            {
                _view.DeletedObject.DataSource = customerService.GetAllCustomerNotActive();
            }
            else
            {
                _view.DeletedObject.DataSource = null;

            }
        }
        private void PopualteActiveObjects()
        {
            if (customerService.GetAllCustomer().Any())
            {
                _view.ActiveObject.DataSource = customerService.GetAllCustomer();
            }
            else
            {
                _view.ActiveObject.DataSource = null;

            }
        }
        // Event Handler:
        public void HandelEvents()
        {
            _view.AddNewClient.Click += new EventHandler(NewCustomerButton_onClick);
            _view.ActiveObject.DoubleClick += new EventHandler(dgvActiveObjects_DoubleClick);
            _view.DeletedObject.DoubleClick += new EventHandler(dgvDeletedObjects_DoubleClick);
            _view.SearchTextBox.TextChanged += new EventHandler(txtSearch_TextChanged);
            _view.TabControl.SelectedIndexChanged += new EventHandler(tabDGVContainer_SelectedIndexChanged);
        }
        private void NewCustomerButton_onClick(object sender, EventArgs e)
        {
            frmNewCustomer.Instance.ShowDialog();
        }
        // 3- Update
        public void dgvActiveObjects_DoubleClick(object sender, EventArgs e)
        {
            Guid ID = new Guid(_view.ActiveObject.CurrentRow.Cells["ActiveObjectId"].Value.ToString());
            OnDoubleCLickDGV(ID);
        }
        public void dgvDeletedObjects_DoubleClick(object sender, EventArgs e)
        {
            Guid ID = new Guid(_view.DeletedObject.CurrentRow.Cells["NotActiveObjectId"].Value.ToString());
            OnDoubleCLickDGV(ID);
        }
        private void OnDoubleCLickDGV(Guid ID)
        {
            var model = customerService.GetCustomerById(ID);
            frmNewCustomer.Instance.ID = model.Id;
            frmNewCustomer.Instance.SuppliersName.Text = model.Name;
            frmNewCustomer.Instance.IdentityNumber.Text = model.NationalIdentity.ToString();
            frmNewCustomer.Instance.IsActive.Checked = model.IsActive;
            frmNewCustomer.Instance.FirmName.Text = model.FirmName;
            frmNewCustomer.Instance.Address.Text = model.Address;
            frmNewCustomer.Instance.TradeLicense.Text = model.CommercialRegister;
            frmNewCustomer.Instance.RefSupplierNumber.Text = model.ReferenceNumber.ToString();
            frmNewCustomer.Instance.Note.Text = model.Description;
            frmNewCustomer.Instance.Mobile.Text = model.Mobile;
            frmNewCustomer.Instance.TaxNumber.Text = model.TaxNumber;
            frmNewCustomer.Instance.OpeningBalance.Value = model.OpeningBalance;
            frmNewCustomer.Instance.Fax.Text = model.FaxNumber;
            frmNewCustomer.Instance.FirmPhoneNumber.Text = model.Phone;
            frmNewCustomer.Instance.IsCustomer.Checked = model.IsCustomer;
            frmNewCustomer.Instance.UpdateObject.Visible = true;
            frmNewCustomer.Instance.AddNewObject.Visible = false;
            frmNewCustomer.Instance.cbIsActive.Enabled = true;
            frmNewCustomer.Instance.ShowDialog();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_view.TabControl.SelectedIndex == 0)
            {
                _view.ActiveObject.DataSource = customerService.GetAllCustomer().
                     Where(d => d.Name.Contains(_view.SearchTextBox.Text)
                     || d.Phone.ToString().Contains(_view.SearchTextBox.Text)
                     || d.ReferenceNumber.ToString().Contains(_view.SearchTextBox.Text)).ToList();
            }
            else
            {
                _view.DeletedObject.DataSource = customerService.GetAllCustomerNotActive().
                    Where(d => d.Name.Contains(_view.SearchTextBox.Text)
                     || d.Phone.ToString().Contains(_view.SearchTextBox.Text)
                     || d.ReferenceNumber.ToString().Contains(_view.SearchTextBox.Text)).ToList();
            }
        }
        private void tabDGVContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_view.TabControl.SelectedIndex == 0)
            {
                _view.ActiveObject.DataSource = customerService.GetAllCustomer();
            }
            else if (_view.TabControl.SelectedIndex == 1)
            {
                _view.DeletedObject.DataSource = customerService.GetAllCustomerNotActive();
            }
        }
    }
}
