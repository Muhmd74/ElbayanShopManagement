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

namespace ElbayaNPresentation
{
    public partial class frmMainBoard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMainBoard()
        {
            InitializeComponent();
        }

        //async Task LoadModuleAsync(ModuleInfo module)
        //{
        //    await Task.Factory.StartNew(m =>
        //   {

        //   });
        //}

        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            Ribbon.SelectPage(ribbonPage1);
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {
        }
    }
}