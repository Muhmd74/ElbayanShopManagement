using DevExpress.XtraEditors;
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
            cbxMainCategory.DataSource = presenter.FillcbxMainCategory();
            cbxMainCategory.DisplayMember = "Name";
            cbxMainCategory.ValueMember = "Id";

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

        //private Guid CategoryID = new Guid(cbxMainCategory.ValueMember);

        public string SubCategoryName { get => txtName.Text; set => txtName.Text = value; }
        public string SubCategoryDescription { get => txtName.Text; set => txtName.Text = value; }
        public List<SubCategoryDto> subCategories { get; set; }
        public SubCategoryPresenter presenter { private get; set; }
        public List<CategoryDto> MainCategory { get; set; }
        public string CategoryId { get => cbxMainCategory.ValueMember; set => cbxMainCategory.SelectedValue = value; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.OnClickbtnAdd();
        }
    }
}
