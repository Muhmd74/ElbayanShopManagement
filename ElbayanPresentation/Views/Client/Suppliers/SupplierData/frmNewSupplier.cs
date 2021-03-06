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

namespace ElbayaNPresentation.Views.Client.Suppliers.SupplierData
{
    public partial class frmNewSupplier : DevExpress.XtraEditors.XtraForm
    {
        public frmNewSupplier()
        {
            InitializeComponent();
            _instance = this;

            // Hanle Full screen Issues 
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Normal;
        }
        private static frmNewSupplier _instance;
        public static frmNewSupplier Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmNewSupplier();
                return _instance;
            }
        }
    }
}