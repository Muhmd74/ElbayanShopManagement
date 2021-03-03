using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Customers.Building;
using ElbayanServices.Repository.Customers.Building.Dtos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Building
{
    public class BuildingPresenter
    {
        private readonly IViewBuilding _view;
        private readonly BuildingService buildingService = new BuildingService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public BuildingPresenter(IViewBuilding view)
        {
            _view = view;
        }

        public void OnloadUCBuilding()
        {
            DataGridViewStyle.StyleDatagridview(_view.dgvActiveObjects);
            DataGridViewStyle.StyleDatagridview(_view.dgvDeletedObjects);

            // Load Data Grid:
            PopualteActiveObjects();
            PopulateDeletedObject();

            _view.btnDeleteObject.Enabled = false;
            _view.btnUpdateObject.Enabled = false;
        }

        // Populate All Builing objects in Data Grid View
        // 2- Read:
        public void PopualteActiveObjects()
        {
            _view.dgvActiveObjects.DataSource = buildingService.GetAllBuilding().ToList();
        }
        public void PopulateDeletedObject()
        {
            _view.dgvDeletedObjects.DataSource = buildingService.GetAllBuildingDeleted().ToList();
        }

         // CRUD Operation: 
         // 1- Create:
         public void CreateNewObject()
         {
            if(_view.BuildingName.Text != "")
           {
                buildingService.Create(new BuildingDto
                {
                    Name = _view.BuildingName.Text,
                    Description = _view.BuildingDescription.Text,
                    Address = _view.BuildingAddress.Text,
                    PhoneNumber = _view.BuildingPhoneNumber.Text
                });

                // Refresh DGV All Active Object:
                PopualteActiveObjects();
                PopulateDeletedObject();
                ClearUcControls();
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
            _view.BuildingId = new Guid(_view.dgvActiveObjects.CurrentRow.Cells["ActiveBuildingId"].Value.ToString());
            _view.BuildingName.Text =_view.dgvActiveObjects.CurrentRow.Cells["ActiveBuilingName"].Value.ToString();
            _view.BuildingDescription.Text =_view.dgvActiveObjects.CurrentRow.Cells["ActiveBuildingDescription"].Value.ToString();
            _view.BuildingAddress.Text =_view.dgvActiveObjects.CurrentRow.Cells["ActiveBuildingAddress"].Value.ToString();
            _view.BuildingPhoneNumber.Text =_view.dgvActiveObjects.CurrentRow.Cells["ActiveBuildingPhoneNUmber"].Value.ToString();

            // Disable Add new button:
            _view.btnAddObject.Enabled = false;
            _view.btnDeleteObject.Enabled = true;
            _view.btnUpdateObject.Enabled = true;

        }
        // 2.3 Update -> Implement Update active Objects:
        public void OnClickbtnUpdate()
        {
            if (_view.BuildingName.Text != "")
            {
                buildingService.Update(new BuildingDto
                {
                    Id = _view.BuildingId,
                    Name = _view.BuildingName.Text,
                    Description = _view.BuildingDescription.Text,
                    Address = _view.BuildingAddress.Text,
                    PhoneNumber = _view.BuildingPhoneNumber.Text
                });
                ClearUcControls();
                _view.btnAddObject.Enabled = true;
                _view.btnDeleteObject.Enabled = false;
                _view.btnUpdateObject.Enabled = false;
                PopualteActiveObjects();
                PopulateDeletedObject();
            }
            else
            {
                MessageBox.Show("كرما لا بد من إدخال حقل الإسم", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }
      
        public void OnClickbtnDelete()
        {
            if (_view.BuildingName.Text != "")
            {
                buildingService.DeleteOrRestore(_view.BuildingId);
                ClearUcControls();
                _view.btnAddObject.Enabled = true;
                _view.btnDeleteObject.Enabled = false;
                _view.btnUpdateObject.Enabled = false;
                PopualteActiveObjects();
                PopulateDeletedObject();
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
            _view.BuildingId = new Guid(_view.dgvDeletedObjects.CurrentRow.Cells["DeletedBuildingId"].Value.ToString());
            _view.BuildingName.Text = _view.dgvDeletedObjects.CurrentRow.Cells["DeletedObjectName"].Value.ToString();
            _view.BuildingDescription.Text = _view.dgvDeletedObjects.CurrentRow.Cells["DeletedObjectDescription"].Value.ToString();
            _view.BuildingAddress.Text = _view.dgvDeletedObjects.CurrentRow.Cells["DeletedObjectAddress"].Value.ToString();
            _view.BuildingPhoneNumber.Text = _view.dgvDeletedObjects.CurrentRow.Cells["DeletedObjectPhoneNumber"].Value.ToString();
            // Disable Add new button:
            _view.btnAddObject.Enabled = false;
            _view.btnDeleteObject.Enabled = true;
            _view.btnUpdateObject.Enabled = true;
        }

        // 2.5 Update -> Tab Control index change event

        public void OnIndexChangedTabContainer()
        {
            if(_view.dgvContainer.SelectedIndex == 0)
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
            _view.BuildingName.Text = _view.BuildingDescription.Text
                = _view.BuildingAddress.Text = _view.BuildingPhoneNumber.Text = "";
        }
   
    }
}
