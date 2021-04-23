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
    public partial class frmPurchaseMovement : MetroFramework.Forms.MetroForm
    {
        public frmPurchaseMovement()
        {
            InitializeComponent();
            _instance = this;
        }
        private static frmPurchaseMovement _instance;
        public static frmPurchaseMovement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmPurchaseMovement();
                return _instance;
            }
        }
    }
}
