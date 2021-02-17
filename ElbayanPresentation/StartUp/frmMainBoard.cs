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
    public partial class frmMainBoard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMainBoard()
        {
            InitializeComponent();
        }


        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            Ribbon.SelectPage(ribbonPage1);
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
            accordionControlElement21_Click(null, null);
        }
    }
}