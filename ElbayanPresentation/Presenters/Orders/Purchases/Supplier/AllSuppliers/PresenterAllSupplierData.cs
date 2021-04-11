using System.Linq;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Purchases.Supplier.AllSuppliers;
using ElbayanServices.Repository.Clints.Supplier;
using ElbayaNPresentation.Views.Client;
using System;

namespace ElbayaNPresentation.Presenters.Purchases.Supplier.AllSuppliers
{
    public class PresenterSupplierData
    {
        private readonly IViewAllSuppleir _view;
        private readonly SupplierService supplierService = new SupplierService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public PresenterSupplierData(IViewAllSuppleir view)
        {
            _view = view;
        }
        public void OnLoadUC()
        {
            DataGridViewStyle.StyleDatagridview(_view.ActiveObject);
            DataGridViewStyle.StyleDatagridview(_view.DeletedObject);

            //// Load Data Grid:
            PopualteActiveObjects();
            PopulateDeletedObject();

        }

        // Populate All Builing objects in Data Grid View
        // 2- Read:
        public void PopualteActiveObjects()
        {
            _view.ActiveObject.DataSource = supplierService.GetAllSupplier().ToList();
        }
        public void PopulateDeletedObject()
        {
            _view.DeletedObject.DataSource = supplierService.GetAllSupplierNotActive().ToList();
        }


        // 1 - Create 
        public void OnClickbtnAddNewObject()
        {
            frmNewClient.Instance.IsSupplier = false;
            frmNewClient.Instance.ShowDialog();
        }
        // 3- Update
        public void OnDoubleClickdgvActiveObject()
        {
            Guid ID = new Guid(_view.ActiveObject.CurrentRow.Cells["ActiveObjectId"].Value.ToString());
            OnDoubleCLickDGV(ID);
        } 
        public void OnDoubleClickdgvNotActiveObject()
        {
            Guid ID = new Guid(_view.DeletedObject.CurrentRow.Cells["NotActiveObjectId"].Value.ToString());
            OnDoubleCLickDGV(ID);
        }
        private void OnDoubleCLickDGV(Guid ID)
        {
            var model = supplierService.GetSupplierById(ID);
            frmNewClient.Instance.ID = model.Id;
            frmNewClient.Instance.SuppliersName.Text = model.Name;
            frmNewClient.Instance.IdentityNumber.Text = model.NationalIdentity.ToString();
            frmNewClient.Instance.IsActive.Checked = model.IsActive;
            frmNewClient.Instance.FirmName.Text = model.FirmName;
            frmNewClient.Instance.Address.Text = model.Address;
            frmNewClient.Instance.TradeLicense.Text = model.CommercialRegister;
            frmNewClient.Instance.RefSupplierNumber.Text = model.ReferenceNumber.ToString();
            frmNewClient.Instance.Note.Text = model.Description;
            frmNewClient.Instance.Mobile.Text = model.Mobile;
            frmNewClient.Instance.TaxNumber.Text = model.TaxNumber;
            frmNewClient.Instance.OpeningBalance.Value = model.OpeningBalance;
            frmNewClient.Instance.Fax.Text = model.FaxNumber;
            frmNewClient.Instance.FirmPhoneNumber.Text = model.Phone;

            frmNewClient.Instance.UpdateObject.Visible = true;
            frmNewClient.Instance.ShowDialog();
        }

        internal void OnSelectedIndexChanged_TabControl()
        {
            if(_view.TabControl.SelectedIndex == 0)
            {
                _view.ActiveObject.DataSource = supplierService.GetAllSupplier().ToList();
            }
            else if (_view.TabControl.SelectedIndex == 1)
            {
                _view.DeletedObject.DataSource = supplierService.GetAllSupplierNotActive().ToList();
            }
        }

        // Search ->
        public void OnTextChnagedtxtSearch()
        {
            if (_view.TabControl.SelectedIndex == 0)
            {
                _view.ActiveObject.DataSource = supplierService.GetAllSupplier().
                     Where(d => d.Name.Contains(_view.SearchtxtBox.Text)
                     || d.Phone.ToString().Contains(_view.SearchtxtBox.Text)
                     || d.ReferenceNumber.ToString().Contains(_view.SearchtxtBox.Text)).ToList();
            }
            else
            {
                _view.DeletedObject.DataSource = supplierService.GetAllSupplierNotActive().
                    Where(d => d.Name.Contains(_view.SearchtxtBox.Text)
                     || d.Phone.ToString().Contains(_view.SearchtxtBox.Text)
                     || d.ReferenceNumber.ToString().Contains(_view.SearchtxtBox.Text)).ToList();
            }
        }

    }
}
