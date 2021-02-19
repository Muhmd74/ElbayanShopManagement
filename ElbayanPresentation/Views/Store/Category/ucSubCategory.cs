using DevExpress.XtraEditors;
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
            Presenter = new SubCategoryPresenter(this);

            // Pupulate Main category in combo box
            FillMaincategorycbx();

            // Load All sub categories in Data grid view with style
            DataGridViewStyle.StyleDatagridview(dgvSubCategory);
            dgvSubCategory.DataSource = Presenter.GetAllSubCategory();
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

        // handle Guid Ids
        // sub category ID
        private Guid SubCatID;
        // main category id
        private Guid MainCatID;
        public string SubCategoryName { get => txtName.Text; set => txtName.Text = value; }
        public string SubCategoryDescription { get => txtDescription.Text; set => txtDescription.Text = value; }
        public string DgvMainCategoryName { get; set; }
        public List<SubCategoryDto> subCategories { get; set; }
        public SubCategoryPresenter Presenter { private get; set; }
        public List<CategoryDto> MainCategory { get; set; }
        public string CategoryId { get => cbxMainCategory.SelectedValue.ToString(); set => cbxMainCategory.SelectedValue = value; }

        public void FillMaincategorycbx()
        {
            // Pupulate Main category in combo box
            cbxMainCategory.DataSource = Presenter.FillcbxMainCategory();
            cbxMainCategory.DisplayMember = "Name";
            cbxMainCategory.ValueMember = "Id";
            cbxMainCategory.SelectedValue = "Id";
        }



        private void dgvSubCategory_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSubCategory.CurrentRow.Index != -1)
            {
                btnAdd.Enabled = false;
                btnDeleteByOne.Enabled = false;
                txtName.Text = dgvSubCategory.CurrentRow.Cells["dgvSubCategoryName"].Value.ToString();
                txtDescription.Text = dgvSubCategory.CurrentRow.Cells["dgvSubcategoryDescription"].Value.ToString();
                SubCatID = new Guid(dgvSubCategory.CurrentRow.Cells["dgvSubCategoryID"].Value.ToString());
                MainCatID = new Guid(dgvSubCategory.CurrentRow.Cells["dgvMainCategoryId"].Value.ToString());
                // dgvMainCategoryName
                DgvMainCategoryName  = dgvSubCategory.CurrentRow.Cells["dgvMainCategoryName"].Value.ToString();
                cbxMainCategory.Text = DgvMainCategoryName;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                if (cbxMainCategory.SelectedItem != null)
                {
                    Presenter.OnClickbtnAdd();
                    MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                    txtName.Clear();
                    txtDescription.Clear();
                    errorProvider.Clear();
                    cbxMainCategory.Text = "";
                    dgvSubCategory.DataSource = Presenter.GetAllSubCategory();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            if (txtName.Text != string.Empty)
            {
                if (cbxMainCategory.SelectedItem != null)
                {
                    Presenter.OnClickbtnUpdate(SubCatID, new Guid(CategoryId));
                    MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                    btnAdd.Enabled = true;
                    btnDeleteByOne.Enabled = true;
                    cbxMainCategory.Text = txtDescription.Text = txtName.Text = "";
                    dgvSubCategory.DataSource = Presenter.GetAllSubCategory();
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
            //}
        }
    }
}
