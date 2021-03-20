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
    public partial class frmOrderPurchase : MetroFramework.Forms.MetroForm
    {
        public frmOrderPurchase()
        {
            InitializeComponent();
            _intsance = this;
            txtBarcode.Select();
        }
        private static frmOrderPurchase _intsance;
        public static frmOrderPurchase Intance
        {
            get
            {
                if (_intsance == null)
                    _intsance = new frmOrderPurchase();
                return _intsance;
            }
        }

    }
}
