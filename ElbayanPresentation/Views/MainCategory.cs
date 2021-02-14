using ElbayanPresentation.Presenters.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayanPresentation.Views
{
    public partial class MainCategory : Form, IViewMainCategory
    {
        public MainCategory()
        {
            InitializeComponent();
            Presenter = new MainCategoryPresenter(this);
        }

        public string CategoryName { get => txtCategoryName.Text; set => txtCategoryName.Text = value; }
        public string CategoryDescription { get => txtCategoryDescription.Text; set => txtCategoryDescription.Text = value; }
        public MainCategoryPresenter Presenter { private get; set; }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Presenter.click();
           
        }
    }
}
