using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Products.Units.LargeUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Unit.LargeUnit
{
    public class LargeUnitPresenter
    {
        private readonly IViewLargeUnit _view;
        private readonly LargeUnitService largeUnit = new LargeUnitService(new ElbayanDatabase.ConnectionTools.ConnectionOption());


        public LargeUnitPresenter(IViewLargeUnit view)
        {
            _view = view;
        }

        public void OnLoadUC()
        {
            DataGridViewStyle.StyleDatagridview(_view.ActiveObject);
            DataGridViewStyle.StyleDatagridview(_view.DeletedObject);
            PopulateAllUnitDataGridView();
            PopulateAllDeletedUnit();
            _view.UpdateObject.Enabled = false;
            _view.DeleteObject.Enabled = false;
        }
        public void PopulateAllUnitDataGridView()
        {

            if (largeUnit.GetAllLargeUnit().Any())
            {
                _view.ActiveObject.DataSource = largeUnit.GetAllLargeUnit().ToList();
            }
            else
            {
                _view.ActiveObject.DataSource = null;
            }

            /// Description: columns[0] == Name
            //dgvLargeUnit.Columns[2].Visible = true;
            //dgvLargeUnit.Columns[3].Visible = false;
        } 
        public void PopulateAllDeletedUnit()
        {

            if (largeUnit.GetAllLargeUnitDeleted().Any())
            {
                _view.DeletedObject.DataSource = largeUnit.GetAllLargeUnit().ToList();
            }
            else
            {
                _view.DeletedObject.DataSource = null;
            }
        }
        public void AddNewUnit()
        {
            if (_view.LargeUnitName.Text != string.Empty)
            {
                largeUnit.Add(new LargeUnitDto
                {
                    Name = _view.LargeUnitName.Text,
                    Description = _view.LargeUnitDescirption.Text
                });
                _view.ActiveObject.DataSource = largeUnit.GetAllLargeUnit().ToList();
                ClearControls();
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("لا بد من إدخال اسم الوحدة", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }
        private void ClearControls()
        {
            _view.LargeUnitName.Text = _view.LargeUnitDescirption.Text = _view.SearchTextBox.Text = string.Empty;
        }
        // Get ByID
        private void GetObjectByID(Guid ID)
        {
            var model = largeUnit.Get(ID);
            _view.LargeUnitName.Text = model.Name;
            _view.LargeUnitDescirption.Text = model.Description;
        }
        public void OnDoubleClickActiveObjectDGV()
        {
            _view.ID = new Guid(_view.ActiveObject.CurrentRow.Cells["ActiveObjectID"].Value.ToString());
            GetObjectByID(_view.ID);
            _view.AddObject.Enabled = false;
            _view.UpdateObject.Enabled = true;
            _view.DeleteObject.Enabled = true;
        }
        internal void OnTextChangedSearch()
        {
            if (_view.DGVTabControl.SelectedIndex == 0)
            {
                _view.ActiveObject.DataSource = largeUnit.GetAllLargeUnit().Where(d => d.Name.Contains(_view.SearchTextBox.Text)).ToList();
            }
            else if (_view.DGVTabControl.SelectedIndex == 1)
            {
                _view.DeletedObject.DataSource = largeUnit.GetAllLargeUnitDeleted().Where(d => d.Name.Contains(_view.SearchTextBox.Text)).ToList();
            }
        }
        public void OnDoubleClickDeletedObjectDGV()
        {
            _view.ID = new Guid(_view.DeletedObject.CurrentRow.Cells["DeletedObjectID"].Value.ToString());
            GetObjectByID(_view.ID);
            _view.AddObject.Enabled = false;
            _view.UpdateObject.Enabled = false;
            _view.DeleteObject.Enabled = true;
        }
        public void OnSelectedIndexChangedTabCOntrol() {
            if (_view.DGVTabControl.SelectedIndex == 0)
            {
                ClearControls();
                _view.AddObject.Enabled = true;
                _view.DeleteObject.Text = "أرشفة الوحدة";
                _view.UpdateObject.Enabled = false;
                _view.DeleteObject.Enabled = false;
                _view.ActiveObject.DataSource = largeUnit.GetAllLargeUnit().ToList();
            }
            else if (_view.DGVTabControl.SelectedIndex == 1)
            {
                //dgvDeletedLargeUnit.Columns[2].Visible = false;
                //DataGridViewStyle.StyleDatagridview(dgvDeletedLargeUnit);

                _view.AddObject.Enabled = false;
                _view.DeleteObject.Text = "إستعادة الوحدة";
                _view.UpdateObject.Enabled = false;
                _view.DeleteObject.Enabled = true;
                ClearControls();
                _view.DeletedObject.DataSource = largeUnit.GetAllLargeUnitDeleted().ToList();
            }
        }
        public void OnClickUpdatebtn()
        {
            if (_view.LargeUnitName.Text != string.Empty)
            {
                largeUnit.Update(new LargeUnitDto
                {
                    Id = _view.ID,
                    Name = _view.LargeUnitName.Text,
                    Description = _view.LargeUnitDescirption.Text
                });
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                ClearControls();
                _view.ActiveObject.DataSource = largeUnit.GetAllLargeUnit().ToList();
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
            
        }
        public void DeletedOrRestore()
        {
            if (_view.LargeUnitName.Text != string.Empty)
            {
                largeUnit.DeleteOrRestore(_view.ID);
                ClearControls();
                if (_view.DGVTabControl.SelectedIndex == 0)
                {
                    _view.ActiveObject.DataSource = largeUnit.GetAllLargeUnit().ToList();
                }
                else
                {
                    _view.DeletedObject.DataSource = largeUnit.GetAllLargeUnitDeleted().ToList();
                }
                MessageBox.Show("تمت العملية بنجاح", "تأكيد", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }

        }
      
    }
}
