﻿using DevExpress.XtraEditors;
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

namespace ElbayaNPresentation.Views.Store.Category 
{
    public partial class ucMaincategory : DevExpress.XtraEditors.XtraUserControl, IViewMainCategory
    {

       private static ucMaincategory _instance;

        public ucMaincategory()
        {
            InitializeComponent();
            Presenter = new MainCategoryPresenter(this);
            dgvMainCategory.DataSource = Presenter.GetCategories();
            dgvMainCategory.Columns[0].Visible = false;
            DataGridViewStyle.StyleDatagridview(dgvMainCategory);

        }
        private Guid CatID;
        public static ucMaincategory Instance
    {
        get
        {
            if (_instance == null)
                _instance = new ucMaincategory();
            return _instance;
        }
    }

        public List<CategoryDto> MainCategory { get; set; }
        public MainCategoryPresenter Presenter { private get;  set; }
        public string MainCategoryName { get => txtName.Text; set => txtName.Text = value; }
        public string MainCategoryDescription { get => txtDescription.Text; set => txtDescription.Text = value; }

        private void dgvMainCategory_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMainCategory.CurrentRow.Index != -1)
            {
                txtName.Text = dgvMainCategory.CurrentRow.Cells["CategoryName"].Value.ToString();
                txtDescription.Text = dgvMainCategory.CurrentRow.Cells["Description"].Value.ToString();
                CatID = new Guid(dgvMainCategory.CurrentRow.Cells["ID"].Value.ToString());
            }
        }

        private void ActiveMainCategory_Selected(object sender, TabControlEventArgs e)
        {
            if(ActiveMainCategory.SelectedIndex == 0)
            {
                btnAdd.Enabled = true;
                btnDeleteByOne.Text = "أرشفة التصنيف";
                btnUpdate.Enabled = true;
                txtDescription.Text = txtName.Text = txtSearch.Text = "";
            }
            else if (ActiveMainCategory.SelectedIndex == 1)
            {
                dgvDeletedMainCategory.DataSource = Presenter.GetDeletedCategories();
                dgvDeletedMainCategory.Columns[0].Visible = false;
                DataGridViewStyle.StyleDatagridview(dgvDeletedMainCategory);
                btnAdd.Enabled = false;
                btnDeleteByOne.Text = "إستعادة التصنيف";
                btnUpdate.Enabled = false;
                txtDescription.Text = txtName.Text = txtSearch.Text = "";
            }
        }

        private void dgvDeletedMainCategory_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDeletedMainCategory.CurrentRow.Index != -1)
            {
                txtName.Text = dgvDeletedMainCategory.CurrentRow.Cells["DeletedName"].Value.ToString();
                txtDescription.Text = dgvDeletedMainCategory.CurrentRow.Cells["DeletedDescription"].Value.ToString();
                CatID = new Guid(dgvDeletedMainCategory.CurrentRow.Cells["ID"].Value.ToString());
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                Presenter.OnClickAddButtonFuction();
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                txtName.Clear();
                txtDescription.Clear();
                dgvMainCategory.DataSource = Presenter.GetCategories();
            }
            else
            {
                MessageBox.Show("لا بد من إدخال اسم التصنيف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                Presenter.OnCLickbtnUpdate(CatID);
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                txtName.Clear();
                txtDescription.Clear();
                dgvMainCategory.DataSource = Presenter.GetCategories();
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnDeleteByOne_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                Presenter.OnClickDelete(CatID);
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                txtName.Clear();
                txtDescription.Clear();
                dgvMainCategory.DataSource = Presenter.GetCategories();
                if (ActiveMainCategory.SelectedIndex == 1)
                {
                    dgvDeletedMainCategory.DataSource = Presenter.GetDeletedCategories();
                }
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
