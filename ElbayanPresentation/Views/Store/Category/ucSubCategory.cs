﻿using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Store.Category.SubCategory;
using ElbayanServices.Repository.Products.Category.Dtos;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
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
            presenter = new SubCategoryPresenter(this);

            // Pupulate Main category in combo box
            FillMaincategorycbx();

            // Load All sub categories in Data grid view with style
            DataGridViewStyle.StyleDatagridview(dgvSubCategory);
            dgvSubCategory.DataSource = presenter.GetAllSubCategory();
            dgvSubCategory.Columns[0].Visible = false;
            dgvSubCategory.Columns[3].Visible = false;
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
         
        public string SubCategoryName { get => txtName.Text; set => txtName.Text = value; }
        public string SubCategoryDescription { get => txtName.Text; set => txtName.Text = value; }
        public List<SubCategoryDto> subCategories { get; set; }
        public SubCategoryPresenter presenter { private get; set; }
        public List<CategoryDto> MainCategory { get; set; }
        public string CategoryId { get => cbxMainCategory.SelectedValue.ToString(); set => cbxMainCategory.SelectedValue = value; }

        public void FillMaincategorycbx()
        {
            // Pupulate Main category in combo box
            cbxMainCategory.DataSource = presenter.FillcbxMainCategory();
            cbxMainCategory.DisplayMember = "Name";
            cbxMainCategory.ValueMember = "Id";
            cbxMainCategory.SelectedValue = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                if(cbxMainCategory.SelectedItem != null)
                {
                    presenter.OnClickbtnAdd();
                    MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                    txtName.Clear();
                    txtDescription.Clear();
                    errorProvider.Clear();
                    cbxMainCategory.Refresh();
                    //dgvMainCategory.DataSource = Presenter.GetCategories();
                }
                else
                {
                    errorProvider.SetError(cbxMainCategory, "كرما أختر قيمة تصنيف رئيسي");
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
    }
}
