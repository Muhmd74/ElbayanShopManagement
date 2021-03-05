using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Customers.Poses;
using ElbayanServices.Repository.Customers.Poses.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Building.POS
{
    public class POSPresenter
    {
        private readonly IViewPOS _view;
        private readonly PosService posService= new PosService(new ConnectionOption());
        public POSPresenter(IViewPOS view)
        {
            _view = view;
        }

        public void OnloadUC()
        {
            DataGridViewStyle.StyleDatagridview(_view.dgvActiveObjects);
            DataGridViewStyle.StyleDatagridview(_view.dgvDeletedObjects);

            // Load Data Grid:
            PopualteActiveObjects();
            PopulateDeletedObject();
            
            PopulatecbxBuilind();
            _view.btnDeleteObject.Enabled = false;
            _view.btnUpdateObject.Enabled = false;
        }

        // Populate All Builing objects in Data Grid View
        // 2- Read:
        private void PopualteActiveObjects()
        {
            _view.dgvActiveObjects.DataSource = posService.GetAll().ToList();
        }
        private void PopulateDeletedObject()
        {
            //_view.dgvDeletedObjects.DataSource = posService.get().ToList();
        }

        public void PopulatecbxBuilind()
        {
            _view.Buidling.DataSource = posService.GetBuilding().ToList();
            _view.Buidling.DisplayMember = "Name";
            _view.Buidling.ValueMember = "Id";
            _view.Buidling.SelectedValue = "Id";
        }
        // CRUD Operation: 
        // 1- Create:
        public void OnClickbtnAdd()
        {
            if (_view.POSsName.Text != "")
            {
                posService.Create(new PosDto
                {
                    Name = _view.POSsName.Text,
                    BuildingId = new Guid(_view.Buidling.SelectedValue.ToString())
                });

                // Refresh DGV All Active Object:
                PopualteActiveObjects();
                PopulateDeletedObject();
                PopulatecbxBuilind();
                ClearUcControls();
                ConfirmOperation();

            }
            else
            {
                MessageBox.Show("كرما لا بد من إدخال حقل الإسم", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        // 2.2 Update -> Data Grid View Active object Double click Event 

        public void OnDoublClickdgvActiveObject()
        {
            _view.POSsId = new Guid(_view.dgvActiveObjects.CurrentRow.Cells["ActivePOSsId"].Value.ToString());
            _view.POSsName.Text = _view.dgvActiveObjects.CurrentRow.Cells["ActivePOSsName"].Value.ToString();
            //_view.POSsShortCode.Text = _view.dgvActiveObjects.CurrentRow.Cells["ActiveShortCode"].Value.ToString();
            _view.Buidling.Text = _view.dgvActiveObjects.CurrentRow.Cells["ActivePOSBuilding"].Value.ToString();

            // Disable Add new button:
            _view.btnAddObject.Enabled = false;
            _view.btnDeleteObject.Enabled = true;
            _view.btnUpdateObject.Enabled = true;

        }
        // 2.3 Update -> Implement Update active Objects:
        public void OnClickbtnUpdate()
        {
            if (_view.POSsName.Text != "")
            {
                posService.Update(new PosDto
                {
                    Id = _view.POSsId,
                    Name = _view.POSsName.Text,
                    BuildingId = new Guid(_view.Buidling.SelectedValue.ToString())
                });
                ClearUcControls();
                ConfirmOperation();
                _view.btnAddObject.Enabled = true;
                _view.btnDeleteObject.Enabled = false;
                _view.btnUpdateObject.Enabled = false;
                PopualteActiveObjects();
                PopulateDeletedObject();
                PopulatecbxBuilind();
            }
            else
            {
                MessageBox.Show("كرما لا بد من إدخال حقل الإسم", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        public void OnClickbtnDelete()
        {
            if (_view.POSsName.Text != "")
            {
                //posService.DeleteOrRestore(_view.BuildingId);
                //ClearUcControls();
                //_view.btnAddObject.Enabled = true;
                //_view.btnDeleteObject.Enabled = false;
                //_view.btnUpdateObject.Enabled = false;
                //PopualteActiveObjects();
                //PopulateDeletedObject();
            }
            else
            {
                MessageBox.Show("كرما لا بد من إدخال حقل الإسم", "تأكيد", MessageBoxButtons.OK);
                return;
            }
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
            if (_view.dgvContainer.SelectedIndex == 0)
            {
                _view.btnDeleteObject.Text = "أرشفة";
                _view.btnAddObject.Enabled = true;
                _view.btnDeleteObject.Enabled = false;
                _view.btnUpdateObject.Enabled = false;
                ClearUcControls();
            }
            else
            {
                _view.btnAddObject.Enabled = false;
                _view.btnDeleteObject.Enabled = true;
                _view.btnUpdateObject.Enabled = true;
                _view.btnDeleteObject.Text = "إستعادة الأرشفة";
                ClearUcControls();
            }
        }
        private void ClearUcControls()
        {
            _view.POSsName.Text = _view.POSsShortCode.Text = "";
            _view.Buidling.SelectedIndex = -1;
        }

        // Search ->
        public void OnTextChnagedtxtSearch()
        {
            if (_view.dgvContainer.SelectedIndex == 0)
            {
                _view.dgvActiveObjects.DataSource = posService.GetAll().
                     Where(d => d.Name.Contains(_view.SearchtxtBox.Text)).ToList();
            }
            else
            {
                //_view.dgvDeletedObjects.DataSource = posService.GetAllBuildingDeleted().
                //    Where(d => d.Name.Contains(_view.SearchtxtBox.Text)
                //    || d.PhoneNumber.Contains(_view.SearchtxtBox.Text)).ToList();
            }
        }

        private void ConfirmOperation()
        {
            MessageBox.Show("تمت العملية بنجاح !!!!!!!!!!!!!!!", "تأكيد", MessageBoxButtons.OK);
            return;
        }
    }
}
