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
using ElbayaNPresentation.Views.Store.Units;
using ElbayaNPresentation.Views.Store.Unit;
using ElbayaNPresentation.Views.Store.Product;

namespace ElbayaNPresentation
{
    public partial class frmMainBoard : DevExpress.XtraEditors.XtraForm
    {
        public frmMainBoard()
        {
            InitializeComponent();
            
            // Hanle Full screen Issues 
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;
        }

        // Global Functionality:
        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Calling ribbon Pages by side bar: 
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


        // Ribbon Buttons //

        // Product Setting Ribbon pages buttons
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucMaincategory.Instance))
            {
                gcContainer.Controls.Add(ucMaincategory.Instance);
                ucMaincategory.Instance.Dock = DockStyle.Fill;
                ucMaincategory.Instance.BringToFront();
            }
            ucMaincategory.Instance.BringToFront();
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
        private void bbiLatgeUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucMaincategory.Instance))
            {
                gcContainer.Controls.Add(ucMaincategory.Instance);
                ucMaincategory.Instance.Dock = DockStyle.Fill;
                ucMaincategory.Instance.BringToFront();
            }
            ucMaincategory.Instance.BringToFront();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucSubCategory.Instance))
            {
                gcContainer.Controls.Add(ucSmallUnit.Instance);
                ucSmallUnit.Instance.Dock = DockStyle.Fill;
                ucSmallUnit.Instance.BringToFront();
            }
            ucSmallUnit.Instance.BringToFront();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucNewProductCard.Instance))
            {
                gcContainer.Controls.Add(ucNewProductCard.Instance);
                ucNewProductCard.Instance.Dock = DockStyle.Fill;
                ucNewProductCard.Instance.BringToFront();
            }
            ucNewProductCard.Instance.BringToFront();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(AllProductsView.Instance))
            {
                gcContainer.Controls.Add(AllProductsView.Instance);
                AllProductsView.Instance.Dock = DockStyle.Fill;
                AllProductsView.Instance.BringToFront();
            }
            AllProductsView.Instance.BringToFront();
        }
    }
}