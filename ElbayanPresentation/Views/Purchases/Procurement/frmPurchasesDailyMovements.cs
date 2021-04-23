using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Purchases.Procurement
{
    public partial class frmPurchasesDailyMovements : MetroFramework.Forms.MetroForm
    {
        public frmPurchasesDailyMovements()
        {
            InitializeComponent();
            _instance = this;
        }
        private static frmPurchasesDailyMovements _instance;
        public static frmPurchasesDailyMovements Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmPurchasesDailyMovements();
                return _instance;
            }
        }
    }
}
