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

namespace ElbayaNPresentation.Views.Store.Category 
{
    public partial class ucMaincategory : DevExpress.XtraEditors.XtraUserControl, IViewMainCategory
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
       private static ucMaincategory _instance;

    public ucMaincategory()
    {
        InitializeComponent();
        Presenter = new MainCategoryPresenter(this);
        dgvMainCategory.DataSource = Presenter.GetCategories();
        dgvMainCategory.Columns[0].Visible = false;


    }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.OnClickAddButtonFuction();
            MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
            txtName.Clear();
            txtDescription.Clear();
            dgvMainCategory.DataSource = Presenter.GetCategories();


        }

        private void dgvMainCategory_DoubleClick(object sender, EventArgs e)
        {
            if(dgvMainCategory.CurrentRow.Index != -1)
            {
                txtName.Text = dgvMainCategory.CurrentRow.Cells["CategoryName"].Value.ToString();
                txtDescription.Text = dgvMainCategory.CurrentRow.Cells["CategoryDescription"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Presenter.OnCLickbtnUpdate();
            MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
            txtName.Clear();
            txtDescription.Clear();
            dgvMainCategory.DataSource = Presenter.GetCategories();
        }
    }
}
