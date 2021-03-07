using ElbayaNPresentation.Views.Client.Suppliers.SupplierData;
using ElbayaNPresentation.Views.Purchases.Suppliers.SupplierData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Purchases.Suppliers.NewSupplier
{
    public class PresenterNewSupplier
    {
        private readonly IViewNewSupplier _view;

        public PresenterNewSupplier(IViewNewSupplier view)
        {
            _view = view;
        }

        public void OnClickBackToUc()
        {
            if (!frmMainBoard.Instance.gcContainer.Controls.Contains(ucSupplierData.Instance))
            {
                frmMainBoard.Instance.gcContainer.Controls.Clear();
                frmMainBoard.Instance.gcContainer.Controls.Add(ucSupplierData.Instance);
                ucSupplierData.Instance.Dock = DockStyle.Fill;
                ucSupplierData.Instance.BringToFront();
            }
            ucSupplierData.Instance.BringToFront();
            frmNewSupplier.Instance.Close();

        }
        // CRUD Operation: 
        // 1- Create:
        public void OnbtnAddNewObject()
        {
            //if (_view.SuppliersName.Text != "")
            //{
            //    supplierService.Create(new ElbayanServices.Repository.Clints.Suppliers.Supplier.Dtos.SupplierDto
            //    {
            //        SupplierNumber = Convert.ToInt32(_view.SupplierNumber.Text),
            //        Name = _view.SuppliersName.Text,
            //        FirmName = _view.FirmName.Text,
            //        Address = _view.Address.Text,
            //        CommercialRegister = _view.CommercialRegister.Text,
            //        TaxNumber = _view.TaxNumber.Text,
            //        Description = _view.Description.Text,
            //        Mobile = _view.Mobile.Text,
            //        OpeningBalance =Convert.ToInt32(_view.OpeningBalance.Text)
            //    });


            //    // Refresh DGV All Active Object:
            //    PopualteActiveObjects();
            //    PopulateDeletedObject();
            //    ClearUcControls();
            //}
            //else
            //{
            //    MessageBox.Show("كرما لا بد من إدخال حقل الإسم", "تأكيد", MessageBoxButtons.OK);
            //    return;
            //}
        }

        // 2.2 Update -> Data Grid View Active object Double click Event 

        public void OnDoublClickdgvActiveObject()
        {
            //_view.BuildingId = new Guid(_view.dgvActiveObjects.CurrentRow.Cells["ActiveBuildingId"].Value.ToString());
            //_view.BuildingName.Text = _view.dgvActiveObjects.CurrentRow.Cells["ActiveBuilingName"].Value.ToString();
            //_view.BuildingDescription.Text = _view.dgvActiveObjects.CurrentRow.Cells["ActiveBuildingDescription"].Value.ToString();
            //_view.BuildingAddress.Text = _view.dgvActiveObjects.CurrentRow.Cells["ActiveBuildingAddress"].Value.ToString();
            //_view.BuildingPhoneNumber.Text = _view.dgvActiveObjects.CurrentRow.Cells["ActiveBuildingPhoneNUmber"].Value.ToString();

            //// Disable Add new button:
            //_view.btnAddObject.Enabled = false;
            //_view.btnDeleteObject.Enabled = true;
            //_view.btnUpdateObject.Enabled = true;

        }
        // 2.3 Update -> Implement Update active Objects:
        public void OnClickbtnUpdate()
        {
            //if (_view.BuildingName.Text != "")
            //{
            //    buildingService.Update(new BuildingDto
            //    {
            //        Id = _view.BuildingId,
            //        Name = _view.BuildingName.Text,
            //        Description = _view.BuildingDescription.Text,
            //        Address = _view.BuildingAddress.Text,
            //        PhoneNumber = _view.BuildingPhoneNumber.Text
            //    });
            //    ClearUcControls();
            //    _view.btnAddObject.Enabled = true;
            //    _view.btnDeleteObject.Enabled = false;
            //    _view.btnUpdateObject.Enabled = false;
            //    PopualteActiveObjects();
            //    PopulateDeletedObject();
            //}
            //else
            //{
            //    MessageBox.Show("كرما لا بد من إدخال حقل الإسم", "تأكيد", MessageBoxButtons.OK);
            //    return;
            //}
        }

        public void OnClickbtnDelete()
        {
            //if (_view.BuildingName.Text != "")
            //{
            //    buildingService.DeleteOrRestore(_view.BuildingId);
            //    ClearUcControls();
            //    _view.btnAddObject.Enabled = true;
            //    _view.btnDeleteObject.Enabled = false;
            //    _view.btnUpdateObject.Enabled = false;
            //    PopualteActiveObjects();
            //    PopulateDeletedObject();
            //}
            //else
            //{
            //    MessageBox.Show("كرما لا بد من إدخال حقل الإسم", "تأكيد", MessageBoxButtons.OK);
            //    return;
            //}
        }

        // 2.4 Update -> Data Grid View Deleted Double click Event:
        public void OnDoubleClickdgvDeletedObject()
        {
            //_view.BuildingId = new Guid(_view.dgvDeletedObjects.CurrentRow.Cells["DeletedBuildingId"].Value.ToString());
            //_view.BuildingName.Text = _view.dgvDeletedObjects.CurrentRow.Cells["DeletedObjectName"].Value.ToString();
            //_view.BuildingDescription.Text = _view.dgvDeletedObjects.CurrentRow.Cells["DeletedObjectDescription"].Value.ToString();
            //_view.BuildingAddress.Text = _view.dgvDeletedObjects.CurrentRow.Cells["DeletedObjectAddress"].Value.ToString();
            //_view.BuildingPhoneNumber.Text = _view.dgvDeletedObjects.CurrentRow.Cells["DeletedObjectPhoneNumber"].Value.ToString();
            //// Disable Add new button:
            //_view.btnAddObject.Enabled = false;
            //_view.btnDeleteObject.Enabled = true;
            //_view.btnUpdateObject.Enabled = true;
        }

        // 2.5 Update -> Tab Control index change event

        public void OnIndexChangedTabContainer()
        {
            //if (_view.tabControl.SelectedIndex == 0)
            //{
            //    _view.btnDeleteObject.Text = "أرشفة";
            //    _view.btnAddNewObject.Enabled = true;
            //    _view.btnDeleteObject.Enabled = false;
            //    _view.btnUpdateObject.Enabled = false;
            //    ClearUcControls();
            //}
            //else
            //{
            //    _view.btnAddNewObject.Enabled = false;
            //    _view.btnDeleteObject.Enabled = true;
            //    _view.btnUpdateObject.Enabled = true;
            //    _view.btnDeleteObject.Text = "إستعادة الأرشفة";
            //    ClearUcControls();
            //}
        }
        private void ClearUcControls()
        {
            //_view.SuppliersName.Text = _view.Address.Text
            //    = _view.CommercialRegister.Text = _view.TaxNumber.Text = "";
        }

    }
}
