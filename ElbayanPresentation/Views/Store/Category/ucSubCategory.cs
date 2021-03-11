using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Store.Category.SubCategory;
using ElbayanServices.Repository.Products.Category.Dtos;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Store.Category
{
    public partial class ucSubCategory : DevExpress.XtraEditors.XtraUserControl, IViewSubCategory
    {
        public ucSubCategory()
        {
            InitializeComponent();
            Presenter = new SubCategoryPresenter(this);
            _instance = this;

            Presenter.OnLoadUC();
        }
        private static ucSubCategory _instance;

        public static ucSubCategory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSubCategory();
                return _instance;
            }
        }

        public Guid ID { get; set; }
        public Guna2TextBox SubCategoryName { get => txtName; set => txtName = value; }
        public Guna2TextBox SubCategoryDescription { get => txtDescription; set => txtDescription = value; }
        public Guna2TextBox SearchtxtBox { get => txtSearch; set => txtSearch = value; }
        public SubCategoryPresenter Presenter {  get; set; }
        public Guna2ComboBox MainCategory { get => cbxMainCategory; set => cbxMainCategory = value; }
        public DataGridView ActiveObject { get => dgvActiveObject; set => dgvActiveObject = value; }
        public DataGridView DeletectObject { get => dgvDeletedObject; set => dgvDeletedObject = value; }
        public TabControl TabControlDGV { get => ActiveMainCategory; set => ActiveMainCategory = value; }
        public Guna2Button AddObject { get => btnAdd; set => btnAdd = value; }
        public Guna2Button UpdateObject { get => btnUpdate; set => btnUpdate = value; }
        public Guna2Button DeleteObject { get => btnDeleteByOne; set => btnDeleteByOne = value; }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ////if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            ////{
            //if (txtName.Text != string.Empty)
            //{
            //    if (cbxMainCategory.SelectedItem != null)
            //    {
            //        Presenter.OnClickbtnUpdate(SubCatID, new Guid(CategoryId));
            //        MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
            //        btnAdd.Enabled = true;
            //        btnDeleteByOne.Enabled = true;
            //        cbxMainCategory.Text = txtDescription.Text = txtName.Text = "";
            //        dgvActiveObject.DataSource = Presenter.GetAllSubCategory();
            //    }
            //    else
            //    {
            //        errorProvider.SetError(cbxMainCategory, "كرما أختر قيمة تصنيف رئيسي");
            //        MessageBox.Show("كرما أختر قيمة تصنيف رئيس", "تأكيد", MessageBoxButtons.OK);
            //        return;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("لا بد من إدخال اسم التصنيف", "تأكيد", MessageBoxButtons.OK);
            //    return;
            //}
            ////}
        }

        private void btnDeleteByOne_Click(object sender, EventArgs e)
        {
            //if (txtName.Text != string.Empty)
            //{
            //    Presenter.onClickbtnDelete(SubCatID);
            //    txtName.Clear();
            //    txtDescription.Clear();
            //    if (ActiveMainCategory.SelectedIndex == 1)
            //    {
            //        dgvDeletedObject.DataSource = Presenter.GetAllDeletedSubCategory();
            //    }
            //    else if (ActiveMainCategory.SelectedIndex == 0)
            //    {
            //        dgvActiveObject.DataSource = Presenter.GetAllSubCategory();
            //    }
            //    MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
            //    return;
            //}
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            //if (ActiveMainCategory.SelectedIndex == 0)
            //{
            //    dgvActiveObject.DataSource = Presenter.FilterDataGridView().ToList();
            //}
            //else if (ActiveMainCategory.SelectedIndex == 1)
            //{
            //    dgvDeletedObject.DataSource = Presenter.FilterDataGridViewDeleted();
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnAdd();
        }

        private void cbxMainCategory_Click(object sender, EventArgs e)
        {
            Presenter.FillcbxMainCategory();

        }

        private void ActiveMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.OnTabSelectedIndexChande();
        }

        private void dgvActiveObject_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDubleClickActiveObject();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Presenter.OnClickbtnUpdate();
        }

        private void dgvDeletedObject_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDubleClickDeletedObject();
        }

        private void btnDeleteByOne_Click_1(object sender, EventArgs e)
        {
            Presenter.onClickbtnDelete();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Presenter.OnTextChangedSearch();
        }
    }
}
