using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.DXperience.Demos;
using ElbayaNPresentation.Views.Store.Category;

namespace ElbayaNPresentation
{
    public partial class frmMainBoard : DevExpress.XtraEditors.XtraForm
    {
        public frmMainBoard()
        {
            InitializeComponent();
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;
        }


        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            ribbon.SelectPage(rpProductSetting);
            if (!gcContainer.Controls.Contains(ucMaincategory.Instance))
            {
                gcContainer.Controls.Add(ucMaincategory.Instance);
                ucMaincategory.Instance.Dock = DockStyle.Fill;
                ucMaincategory.Instance.BringToFront();
            }
            ucMaincategory.Instance.BringToFront();

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucSubCategory.Instance))
            {
                gcContainer.Controls.Add(ucSubCategory.Instance);
                ucSubCategory.Instance.Dock = DockStyle.Fill;
                ucSubCategory.Instance.BringToFront();
            }
            ucSubCategory.Instance.BringToFront();
        }
        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {
            ribbon.SelectPage(rpProductSetting);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}