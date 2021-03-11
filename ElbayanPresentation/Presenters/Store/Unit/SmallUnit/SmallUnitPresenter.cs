using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Products.Units.LargeUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Unit.SmallUnit
{
    public class SmallUnitPresenter
    {
        private readonly IViewSmallUnit _view;

        private readonly SmallService smallUnit = new SmallService(new ConnectionOption());

        private readonly LargeUnitService largeUnitServices = new LargeUnitService(new ConnectionOption());

        public SmallUnitPresenter(IViewSmallUnit view)
        {
            _view = view;
        }

        public void OnLoadUC()
        {
            DataGridViewStyle.StyleDatagridview(_view.ActiveObject);
            DataGridViewStyle.StyleDatagridview(_view.DeletedObject);
            PopulatecbxLargeUnit();
            PopulateAllUnitDataGridView();
            PopulateDeletedDGV();
            _view.UpdateObject.Enabled = false;
            _view.DeleteObject.Enabled = false;
        }
        public void PopulatecbxLargeUnit()
        {
            // Pupulate Main category in combo box

            _view.LargeUnit.DataSource = null;
            _view.LargeUnit.Items.Clear();
            _view.LargeUnit.DataSource = largeUnitServices.GetAllLargeUnit().ToList();
            _view.LargeUnit.DisplayMember = "Name";
            _view.LargeUnit.ValueMember = "Id";
            _view.LargeUnit.SelectedValue = "Id";
        }
        public void PopulateAllUnitDataGridView()
        {
            if (smallUnit.GetAllSmallUnit().Any())
            {
                _view.ActiveObject.DataSource = smallUnit.GetAllSmallUnit().ToList();
            }
            else
            {
                _view.ActiveObject.DataSource = null;
            }
            _view.ActiveObject.AutoGenerateColumns = false;
        }
        public void PopulateDeletedDGV()
        {

            if (smallUnit.GetAllSmallUnitDeleted().Any())
            {
                _view.DeletedObject.DataSource = smallUnit.GetAllSmallUnitDeleted().ToList();
            }
            else
            {
                _view.DeletedObject.DataSource = null;
            }
            _view.DeletedObject.AutoGenerateColumns = false;
        }

        private void GetByID(Guid ID)
        {
            var model = smallUnit.Get(ID);
            _view.SmallUnitName.Text = model.Name;
            _view.Description.Text = model.Description;
            _view.Weight.Value = Convert.ToDecimal(model.Weight);
            _view.LargeUnit.Text = model.LargeUnitName;

        }
        public void OnDoubleClickActiveDGv()
        {
            if (_view.ActiveObject.CurrentRow.Index != -1)
            {
                _view.ID = new Guid(_view.ActiveObject.CurrentRow.Cells["dgvSmallUnitID"].Value.ToString());
                GetByID(_view.ID);
                _view.AddObject.Enabled = false;
                _view.UpdateObject.Enabled = true;
                _view.DeleteObject.Enabled = true;
            }
        }

        internal void OnDoubleClickDeletedDGv()
        {
            if (_view.DeletedObject.CurrentRow.Index != -1)
            {
                _view.ID = new Guid(_view.DeletedObject.CurrentRow.Cells["dgvSmallUnitIDDeleted"].Value.ToString());
                GetByID(_view.ID);
                _view.AddObject.Enabled = false;
                _view.UpdateObject.Enabled = false;
                _view.DeleteObject.Enabled = true;
            }
        }

        internal void OnTextChangedSearch()
        {
            if (_view.DGVTabControl.SelectedIndex == 0)
            {
                _view.ActiveObject.DataSource = smallUnit.GetAllSmallUnit().Where(d => d.Name.Contains(_view.SearchKeyword.Text)).ToList();
            }
            else if (_view.DGVTabControl.SelectedIndex == 1)
            {
                _view.DeletedObject.DataSource = smallUnit.GetAllSmallUnitDeleted().Where(d => d.Name.Contains(_view.SearchKeyword.Text)).ToList();
            }
        }

        internal void OnSelectedIndexChangedTabContainer()
        {
            if (_view.DGVTabControl.SelectedIndex == 0)
            {
                _view.ActiveObject.DataSource = smallUnit.GetAllSmallUnit().ToList();
                _view.AddObject.Enabled = true;
                _view.UpdateObject.Enabled = true;
                _view.LargeUnit.Enabled = true;
                _view.DeleteObject.Text = "الأرشفة";
                ClearControls();
            }
            else if (_view.DGVTabControl.SelectedIndex == 1)
            {
                _view.DeletedObject.DataSource = smallUnit.GetAllSmallUnitDeleted();
                _view.AddObject.Enabled = false;
                _view.AddObject.Enabled = false;
                _view.DeleteObject.Enabled = true;
                _view.DeleteObject.Text = "  إستعادة الأرشفة";
                ClearControls();
            }
        }

        public void OnClickbtnAdd()
        {
            if (_view.SmallUnitName.Text != string.Empty)
            {
                if (_view.LargeUnit.SelectedItem != null)
                {
                    smallUnit.Add(new SmallUnitDto
                    {
                        Name = _view.SmallUnitName.Text,
                        Description = _view.Description.Text,
                        Weight = _view.Weight.Value.ToString(),
                        LargeUnitId = new Guid(_view.LargeUnit.SelectedValue.ToString())
                    });
                    ClearControls();
                    PopulateAllUnitDataGridView();
                    MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("كرما أختر قيمة وحدة رئيسة", "تأكيد", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("لا بد من إدخال اسم الوحدة الصغرى", "تأكيد", MessageBoxButtons.OK);
                return;
            }

        }
        public void OnclickUpdate()
        {
            if (_view.SmallUnitName.Text != string.Empty)
            {
                if (_view.LargeUnit.SelectedItem != null)
                {
                    smallUnit.Update(new SmallUnitDto
                    {
                        Id = _view.ID,
                        Name = _view.SmallUnitName.Text,
                        Description = _view.Description.Text,
                        LargeUnitId = new Guid(_view.LargeUnit.SelectedValue.ToString()),
                        Weight = _view.Weight.Value.ToString()
                    });
                    ClearControls();
                    PopulateAllUnitDataGridView();
                    MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("كرما أختر قيمة تصنيف رئيس", "تأكيد", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("لا بد من إدخال اسم التصنيف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }


        public void onClickbtnDelete()
        {
            if (_view.SmallUnitName.Text != string.Empty)
            {
                smallUnit.DeleteOrRestore(_view.ID);
                ClearControls();
                if (_view.DGVTabControl.SelectedIndex == 0)
                {
                    PopulateAllUnitDataGridView();
                }
                else if (_view.DGVTabControl.SelectedIndex == 1)
                {
                    PopulateDeletedDGV();
                }
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }

        }

        private void ClearControls()
        {
            _view.SmallUnitName.Text = _view.Description.Text = _view.SearchKeyword.Text = string.Empty;
            _view.Weight.Value = 1.0m;
            _view.LargeUnit.SelectedIndex = -1;
        }
    }

}
