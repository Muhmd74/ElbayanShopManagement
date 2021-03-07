using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElbayaNPresentation.Presenters.Store.Category.MainCategory;
using ElbayanServices.Repository.Products.Category.Dtos;
using System.Runtime.InteropServices;
using ElbayaNPresentation.Presenters.CommonPresenter;
using Guna.UI2.WinForms;

namespace ElbayaNPresentation.Views.Store.Category 
{
    public partial class ucMaincategory : DevExpress.XtraEditors.XtraUserControl, IViewMainCategory
    {

       private static ucMaincategory _instance;

        public ucMaincategory()
        {
            InitializeComponent();

            Presenter = new MainCategoryPresenter(this);
            _instance = this;
            Presenter.OnLoad();

        }
        public Guid ID { get; set; }
        public static ucMaincategory Instance
        {
        get
        {
            if (_instance == null)
                _instance = new ucMaincategory();
            return _instance;
        }
        }
        public MainCategoryPresenter Presenter { private get;  set; }
        public Guna2TextBox MainCategoryName { get => txtName; set => txtName = value; }
        public Guna2TextBox MainCategoryDescription { get => txtDescription; set => txtDescription = value; }
        public Guna2TextBox SearchBox { get => txtSearch; set => txtSearch = value; }
        public DataGridView ActiveObjects { get => dgvActiveObjects; set => dgvActiveObjects = value; }
        public DataGridView DeletedObjects { get => dgvDeletedObjects; set => dgvDeletedObjects = value; }
        public Guna2Button AddNewObject { get => btnAdd; set => btnAdd = value; }
        public Guna2Button UpdateObject { get => btnUpdate; set => btnUpdate = value; }
        public Guna2Button DeleteObject { get => btnDeleteByOne; set => btnDeleteByOne = value; }
        public TabControl dgvTabControl { get => tabDGVContainer; set => tabDGVContainer = value; }

        private void btnAdd_Click_1(object sender, EventArgs e)
        { 
            Presenter.OnClickbtnAdd();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                Presenter.OnCLickbtnUpdate(ID);
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                txtName.Clear();
                txtDescription.Clear();
                //dgvActiveObjects.DataSource = Presenter.GetCategories();
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnDeleteByOne_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                Presenter.OnClickDelete(ID);
                txtName.Clear();
                txtDescription.Clear();
                if (tabDGVContainer.SelectedIndex == 1)
                {
                    //dgvDeletedMainCategory.DataSource = Presenter.GetDeletedCategories();
                }
                else
                {
                    //dgvActiveObjects.DataSource = Presenter.GetCategories();
                }
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (tabDGVContainer.SelectedIndex == 0)
            {
                //dgvActiveObjects.DataSource = Presenter.FilterDataGridView().ToList();
            }
            else if (tabDGVContainer.SelectedIndex == 1)
            {
                //dgvDeletedMainCategory.DataSource = Presenter.FilterDataGridViewDeleted();
            }
        }

        private void ActiveMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDGVContainer.SelectedIndex == 0)
            {
                //dgvActiveObjects.DataSource = Presenter.GetCategories();
                btnAdd.Enabled = true;
                btnDeleteByOne.Text = "أرشفة التصنيف";
                btnUpdate.Enabled = true;
                txtDescription.Text = txtName.Text = txtSearch.Text = "";
            }
            else if (tabDGVContainer.SelectedIndex == 1)
            {
                //dgvDeletedMainCategory.DataSource = Presenter.GetDeletedCategories();
                dgvDeletedObjects.Columns[0].Visible = false;
                DataGridViewStyle.StyleDatagridview(dgvDeletedObjects);
                btnAdd.Enabled = false;
                btnDeleteByOne.Text = "إستعادة التصنيف";
                btnUpdate.Enabled = false;
                txtDescription.Text = txtName.Text = txtSearch.Text = "";
            }
        }

        private void dgvMainCategory_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickdgvActiveObject();
        }

        private void dgvMainCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvActiveObjects.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvDeletedMainCategory_DoubleClick_1(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickdgvDeletedObject();
            //if (dgvDeletedObjects.CurrentRow.Index != -1)
            //{
            //    txtName.Text = dgvDeletedObjects.CurrentRow.Cells["DeletedName"].Value.ToString();
            //    txtDescription.Text = dgvDeletedObjects.CurrentRow.Cells["DeletedDescription"].Value.ToString();
            //    ID = new Guid(dgvDeletedObjects.CurrentRow.Cells["CategoryID"].Value.ToString());
            //}
        }

        private void dgvDeletedMainCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvActiveObjects.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        
    }
}
