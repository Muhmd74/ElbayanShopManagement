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
using DevExpress.XtraEditors;
using ElbayaNPresentation.Views.Store.Building;
using ElbayaNPresentation.Views.Store.POSs;
using ElbayaNPresentation.Views.Client.Suppliers;
using ElbayaNPresentation.Views.Finance.Employee;
using ElbayaNPresentation.StartUp;
using ElbayaNPresentation.Views.Purchases.Procurement;
using ElbayaNPresentation.Views.Settings.Firm;

namespace ElbayaNPresentation
{
    public partial class frmMainBoard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static frmMainBoard _instance;

        public static frmMainBoard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMainBoard();
                return _instance;
            }
        }
        public frmMainBoard()
        {
            InitializeComponent();
            _instance = this;

            this.gcContainer.Controls.Add(ucMainBoard.Instance);
            ucMainBoard.Instance.Dock = DockStyle.Fill;
            ucMainBoard.Instance.BringToFront();
            // Hanle Full screen Issues 
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        //// Global Functionality:
        //private void btnCloseForm_Click(object sender, EventArgs e)
        //{
        //    this.Close();

        //}

        //private void btnMinimizeForm_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;

        //}

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
            if (!gcContainer.Controls.Contains(ucLargeUnits.Instance))
            {
                gcContainer.Controls.Add(ucLargeUnits.Instance);
                ucLargeUnits.Instance.Dock = DockStyle.Fill;
                ucLargeUnits.Instance.BringToFront();
            }
            ucLargeUnits.Instance.BringToFront();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucSmallUnit.Instance))
            {
                gcContainer.Controls.Add(ucSmallUnit.Instance);
                ucSmallUnit.Instance.Dock = DockStyle.Fill;
                ucSmallUnit.Instance.BringToFront();
            }
            ucSmallUnit.Instance.BringToFront();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucAllProductsView.Instance))
            {
                gcContainer.Controls.Clear();
                gcContainer.Controls.Add(ucAllProductsView.Instance);
                ucAllProductsView.Instance.Dock = DockStyle.Fill;
                ucAllProductsView.Instance.BringToFront();
            }
            ucAllProductsView.Instance.BringToFront();
            frmNewProduct.Instance.Presenter.ClearControls();
            frmNewProduct.Instance.Presenter.OnLoad();
            frmNewProduct.Instance.btnUpdate.Visible = false;
            frmNewProduct.Instance.btnDeleteOrRestore.Visible = false;
            frmNewProduct.Instance.ShowDialog();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucAllProductsView.Instance))
            {
                gcContainer.Controls.Add(ucAllProductsView.Instance);
                ucAllProductsView.Instance.Dock = DockStyle.Fill;
                ucAllProductsView.Instance.BringToFront();
            }
            ucAllProductsView.Instance.BringToFront();
        }

        private void barBtnBuilding_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucBuilding.Instance))
            {
                gcContainer.Controls.Add(ucBuilding.Instance);
                ucBuilding.Instance.Dock = DockStyle.Fill;
                ucBuilding.Instance.BringToFront();
            }
            ucBuilding.Instance.BringToFront();
        }

        private void barBtnPOSs_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucPOSs.Instance))
            {
                gcContainer.Controls.Add(ucPOSs.Instance);
                ucPOSs.Instance.Dock = DockStyle.Fill;
                ucPOSs.Instance.BringToFront();
            }
            ucPOSs.Instance.BringToFront();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucAllSupplier.Instance))
            {
                gcContainer.Controls.Clear();
                gcContainer.Controls.Add(ucAllSupplier.Instance);
                ucAllSupplier.Instance.Dock = DockStyle.Fill;
                ucAllSupplier.Instance.BringToFront();
            }
            ucAllSupplier.Instance.BringToFront();

        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gcContainer.Controls.Contains(ucAllEmployeeData.Instance))
            {
                gcContainer.Controls.Clear();
                gcContainer.Controls.Add(ucAllEmployeeData.Instance);
                ucAllEmployeeData.Instance.Dock = DockStyle.Fill;
                ucAllEmployeeData.Instance.BringToFront();
            }
            ucAllEmployeeData.Instance.BringToFront();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOrderPurchase frm = new frmOrderPurchase();
            frm.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!this.gcContainer.Controls.Contains(frm_ProductStock.Instance))
            {
                frm_ProductStock.Instance.TopLevel = false;
                frm_ProductStock.Instance.TopMost = false;
                this.gcContainer.Controls.Add(frm_ProductStock.Instance);
                frm_ProductStock.Instance.Dock = DockStyle.Fill;
                frm_ProductStock.Instance.BringToFront();
                frm_ProductStock.Instance.Show();
            }
            frm_ProductStock.Instance.BringToFront();
            frm_ProductStock.Instance.Show();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!this.gcContainer.Controls.Contains(frmFirmDetail.Instance))
            {
                frmFirmDetail.Instance.TopLevel = false;
                frmFirmDetail.Instance.TopMost = false;
                //frmFirmDetail.Instance.Owner = this;
                this.gcContainer.Controls.Add(frmFirmDetail.Instance);
                frmFirmDetail.Instance.Dock = DockStyle.Fill;
                frmFirmDetail.Instance.BringToFront();
                frmFirmDetail.Instance.Show();
            }
            frmFirmDetail.Instance.BringToFront();
            frmFirmDetail.Instance.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmProductOpeningBalance.Insatnce.ShowDialog();
        }
    }
}