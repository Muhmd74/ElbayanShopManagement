using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Purchases
{
    public partial class frmPurchaseReturns : MetroFramework.Forms.MetroForm
    {
        public frmPurchaseReturns()
        {
            InitializeComponent();
            _instance = this;
            dtpOrderReturnDate.Value = DateTime.Now;
        }
        private static frmPurchaseReturns _instance;
        public static frmPurchaseReturns Instance { get { if (_instance == null) _instance = new frmPurchaseReturns(); return _instance; } }

    }
}
