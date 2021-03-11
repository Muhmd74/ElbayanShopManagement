using ElbayanServices.Repository.Products.Category;
using ElbayanServices.Repository.Products.SubCategory;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using ElbayanDatabase.ConnectionTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Products.Category.Dtos;
using ElbayaNPresentation.Presenters.CommonPresenter;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Category.SubCategory
{
    public class SubCategoryPresenter
    {
        private static IViewSubCategory _view;
        
        private static CategoryService MainCategory = new CategoryService(new ConnectionOption());

        private static SubCategoryService subCategory = new SubCategoryService(new ConnectionOption());

        public SubCategoryPresenter(IViewSubCategory view)
        {
            _view = view;
        }


        public void OnLoadUC()
        {
            FillcbxMainCategory();
            DataGridViewStyle.StyleDatagridview(_view.ActiveObject);
            DataGridViewStyle.StyleDatagridview(_view.DeletectObject);
            PopulatedgvObject();


        }
        public void FillcbxMainCategory()
        {
            _view.MainCategory.DisplayMember = "Name";
            _view.MainCategory.ValueMember = "Id";
            _view.MainCategory.SelectedValue = "Id";
            _view.MainCategory.DataSource = MainCategory.GetAll();

        }
        private void PopulatedgvObject()
        {
            if(subCategory.GetAll().Any()|| subCategory.GetAll().Any())
            {
                _view.ActiveObject.DataSource = subCategory.GetAll().ToList();
                _view.DeletectObject.DataSource = subCategory.GetAllIsDeleted().ToList();
            }
            else
            {
                _view.ActiveObject.DataSource = null;
                _view.DeletectObject.DataSource = null;
            }
        }
        public void OnClickbtnAdd()
        {
            if (_view.SubCategoryName.Text != string.Empty)
            {
                if (_view.MainCategory.SelectedItem != null)
                {
                    subCategory.Add(new SubCategoryDto
                    {
                        Name = _view.SubCategoryName.Text,
                        Description = _view.SubCategoryDescription.Text, 
                        CategoryId = new Guid(_view.MainCategory.SelectedValue.ToString())
                    });
                    _view.ActiveObject.DataSource = subCategory.GetAll().ToList();
                    ClearControls();
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
        internal void OnTabSelectedIndexChande()
        {
            if (_view.TabControlDGV.SelectedIndex == 0)
            {
                _view.ActiveObject.DataSource = subCategory.GetAll().ToList();
                _view.AddObject.Enabled = true;
                _view.UpdateObject.Enabled = true;
                _view.MainCategory.Enabled = true;
                _view.DeleteObject.Text = "الأرشفة";
                ClearControls();
            }
            else if (_view.TabControlDGV .SelectedIndex == 1)
            {
                _view.DeletectObject.DataSource = subCategory.GetAllIsDeleted().ToList();
                _view.AddObject.Enabled = false;
                _view.UpdateObject.Enabled = false;
                _view.MainCategory.Enabled = false;
                _view.DeleteObject.Text = "إستعادة الأرشفة";
                ClearControls();
            }
        }
        public void OnClickbtnUpdate()
        {
            if (_view.SubCategoryName.Text != string.Empty)
            {
                if (_view.MainCategory.SelectedItem != null)
                {
                    subCategory.Update(new SubCategoryDto
                    {
                        Id = _view.ID,
                        CategoryId = new Guid(_view.MainCategory.SelectedValue.ToString()),
                        Name = _view.SubCategoryName.Text,
                        Description = _view.SubCategoryDescription.Text,
                    });
                    _view.ActiveObject.DataSource = subCategory.GetAll().ToList();
                    ClearControls();
                    MessageBox.Show("تمت العملية  بناجاح", "تأكيد", MessageBoxButtons.OK);
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
        public void OnDubleClickActiveObject()
        {
            if (_view.ActiveObject.Rows.Count != 0)
            {
                _view.ID = new Guid(_view.ActiveObject.CurrentRow.Cells["dgvSubCategoryID"].Value.ToString());
                _view.MainCategory.Text = _view.ActiveObject.CurrentRow.Cells["dgvMainCategoryName"].Value.ToString();
                OnDuobleClickDGV(_view.ID);
            }
        }
        public void OnDubleClickDeletedObject()
        {
            if (_view.ActiveObject.Rows.Count != 0)
            {
                _view.ID = new Guid(_view.DeletectObject.CurrentRow.Cells["dgvSubCategoryDeletedID"].Value.ToString());
                _view.MainCategory.Text = _view.DeletectObject.CurrentRow.Cells["dgvSubCategoryDeletedMainCategoryName"].Value.ToString();
                OnDuobleClickDGV(_view.ID);
            }
        }
        private void OnDuobleClickDGV(Guid ID)
        {
            var model = subCategory.GetById(ID);
            _view.SubCategoryName.Text = model.Name;
            _view.SubCategoryDescription.Text = model.Description;
        }
        public void onClickbtnDelete()
        {

            if (_view.SubCategoryName.Text != string.Empty)
            {
                if (_view.MainCategory.SelectedItem != null)
                {
                    if(_view.TabControlDGV.SelectedIndex == 0)
                    {
                         subCategory.DeleteOrRestore(_view.ID);
                        _view.ActiveObject.DataSource = subCategory.GetAll().ToList();
                    }
                    else
                    {
                        subCategory.DeleteOrRestore(_view.ID);
                        _view.DeletectObject.DataSource = subCategory.GetAllIsDeleted().ToList();
                    }
                    ClearControls();
                    MessageBox.Show("تمت العملية  بناجاح", "تأكيد", MessageBoxButtons.OK);
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
        private void ClearControls()
        {
            _view.SubCategoryName.Clear();
            _view.SubCategoryDescription.Clear();
            _view.MainCategory.SelectedIndex = -1;
        }
        public void OnTextChangedSearch()
        {
            //subCategory.GetByName(_view.SearchtxtBox.Text);
            if(_view.TabControlDGV.SelectedIndex == 0)
            {
                _view.ActiveObject.DataSource = subCategory.GetAll().Where(d => d.Name.Contains(_view.SearchtxtBox.Text)).ToList();
            }
            else
            {
                _view.DeletectObject.DataSource = subCategory.GetAllIsDeleted().Where(d => d.Name.Contains(_view.SearchtxtBox.Text)).ToList();

            }
        }
    }
}
