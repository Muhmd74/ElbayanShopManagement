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
            frmNewSupplier.Instance.ShowDialog();
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
            frmNewSupplier.Instance.ID = model.Id;
            frmNewSupplier.Instance.SuppliersName.Text = model.Name;
            frmNewSupplier.Instance.IdentityNumber.Text = model.NationalIdentity.ToString();
            frmNewSupplier.Instance.IsActive.Checked = model.IsActive;
            frmNewSupplier.Instance.FirmName.Text = model.FirmName;
            frmNewSupplier.Instance.Address.Text = model.Address;
            frmNewSupplier.Instance.TradeLicense.Text = model.CommercialRegister;
            frmNewSupplier.Instance.RefSupplierNumber.Text = model.ReferenceNumber.ToString();
            frmNewSupplier.Instance.Note.Text = model.Description;
            frmNewSupplier.Instance.Mobile.Text = model.Mobile;
            frmNewSupplier.Instance.TaxNumber.Text = model.TaxNumber;
            frmNewSupplier.Instance.OpeningBalance.Value = model.OpeningBalance;
            frmNewSupplier.Instance.Fax.Text = model.FaxNumber;
            frmNewSupplier.Instance.FirmPhoneNumber.Text = model.Phone;

            frmNewSupplier.Instance.UpdateObject.Visible = true;
            frmNewSupplier.Instance.ShowDialog();
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
