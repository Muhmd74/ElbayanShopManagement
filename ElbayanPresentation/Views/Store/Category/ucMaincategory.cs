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



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnAdd();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Presenter.OnCLickbtnUpdate();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Presenter.OnTextChangedSearch();
        }

        private void dgvActiveObjects_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickdgvActiveObject();

        }

        private void dgvActiveObjects_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvActiveObjects.Rows[e.RowIndex].Cells["AutoNumber"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvDeletedObjects_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickdgvDeletedObject();

        }

        private void dgvDeletedObjects_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvDeletedObjects.Rows[e.RowIndex].Cells["AutoDeletedNumber"].Value = (e.RowIndex + 1).ToString();
        }

        private void tabDGVContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.OnSelectedIndexChangedTabContainer();

        }

        private void btnDeleteByOne_Click(object sender, EventArgs e)
        {
            Presenter.OnClickDelete();
        }
    }
}
