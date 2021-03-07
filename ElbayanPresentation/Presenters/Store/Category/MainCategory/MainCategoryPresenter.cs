using ElbayanDatabase.ConnectionTools;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Products.Category;
using ElbayanServices.Repository.Products.Category.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Category.MainCategory
{
    public class MainCategoryPresenter
    {
        private readonly IViewMainCategory _view;
        CategoryService Category = new CategoryService(new ConnectionOption());

        public MainCategoryPresenter(IViewMainCategory view)
        {
            _view = view;
        }

        // 1. Create
        public void OnClickbtnAdd()
        {
            if (_view.MainCategoryName.Text != string.Empty)
            {
                Category.Add(new CategoryDto
                {
                    Name = _view.MainCategoryName.Text,
                    Description = _view.MainCategoryDescription.Text
                });
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                ClearControls();
                PopulateDGV();
            }
            else
            {
                MessageBox.Show("لا بد من إدخال اسم التصنيف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
            
        }
        // 2. Read
        public void OnLoad()
        {
            PopulateDGV();
        }
        private void PopulateDGV()
        {
            DataGridViewStyle.StyleDatagridview(_view.ActiveObjects);
            DataGridViewStyle.StyleDatagridview(_view.DeletedObjects);

            if (Category.GetAll().Any() || Category.GetAllDeleted().Any())
            {
                _view.ActiveObjects.DataSource = Category.GetAll().ToList();
                _view.DeletedObjects.DataSource = Category.GetAllDeleted().ToList();
            }
            else
            {
                _view.ActiveObjects.DataSource = null;
                _view.DeletedObjects.DataSource = null;
            }
        }

        // 3. Update
        // - Get ByID
        private void OnDoubleDvgGetById(Guid ID)
        {
            CategoryDto model = Category.GetById(ID);
            _view.MainCategoryName.Text = model.Name;
            _view.MainCategoryDescription.Text = model.Description;

            // Disable Add new button:
            _view.AddNewObject.Enabled = false;
            _view.UpdateObject.Enabled = true;
            _view.DeletedObjects.Enabled = true;
        }
       public void OnDoubleClickdgvActiveObject()
       {
            if (_view.ActiveObjects.CurrentRow.Index != -1)
            {
                _view.ID = new Guid(_view.ActiveObjects.CurrentRow.Cells["MainCategoryID"].Value.ToString());
                OnDoubleDvgGetById(_view.ID);
            }
       }
        public void OnDoubleClickdgvDeletedObject()
       {
            if (_view.ActiveObjects.CurrentRow.Index != -1)
            {
                _view.ID = new Guid(_view.DeletedObjects.CurrentRow.Cells["CategoryID"].Value.ToString());
                OnDoubleDvgGetById(_view.ID);
            }
       }

        public void OnCLickbtnUpdate()
        {
            if (_view.MainCategoryName.Text != string.Empty)
            {
                Category.Update(new CategoryDto
                {
                    Id = _view.ID,
                    Name = _view.MainCategoryName.Text,
                    Description = _view.MainCategoryDescription.Text
                });
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                ClearControls();
                PopulateDGV();
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }
        // 4. Delete
        public void OnClickDelete()
        {
            if (_view.MainCategoryName.Text != string.Empty)
            {
                Category.DeleteOrRestore(_view.ID);
                ClearControls();
                if (_view.dgvTabControl.SelectedIndex == 0)
                {
                    _view.ActiveObjects.DataSource = Category.GetAll().ToList();
                }
                else if(_view.dgvTabControl.SelectedIndex == 1)
                {
                    _view.DeletedObjects.DataSource = Category.GetAllDeleted().ToList();
                }
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }

        }

        // 5. Search 

        public void OnTextChangedSearch()
        {
            if (_view.dgvTabControl.SelectedIndex == 0)
            {
                _view.ActiveObjects.DataSource = Category.GetAll().Where(d => d.Name.Contains(_view.SearchBox.Text)).ToList();
            }
            else if (_view.dgvTabControl.SelectedIndex == 1)
            {
                _view.DeletedObjects.DataSource = Category.GetAllDeleted().Where(d => d.Name.Contains(_view.SearchBox.Text)).ToList();
            }
        }
        // --- Clear Work ----- +

        public void OnSelectedIndexChangedTabContainer()
        {
            if (_view.dgvTabControl.SelectedIndex == 0)
            {
                _view.ActiveObjects.DataSource = Category.GetAll().ToList();
               _view.AddNewObject.Enabled = true;
                _view.DeleteObject.Text = "أرشفة التصنيف";
                _view.UpdateObject.Enabled = true;
                ClearControls();
            }
            else if (_view.dgvTabControl.SelectedIndex == 1)
            {
                _view.DeletedObjects.DataSource = Category.GetAllDeleted().ToList();
                _view.AddNewObject.Enabled = false;
                _view.DeleteObject.Text = "إستعادة التصنيف";
                _view.UpdateObject.Enabled = true;
                ClearControls();
            }
        }
        private void ClearControls()
        {
            _view.MainCategoryName.Text = _view.MainCategoryDescription.Text = _view.SearchBox.Text = "";
        }
    }
}
