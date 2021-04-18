using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Client.Suppliers
{
    public partial class frmSupplierAccountStatement : MetroFramework.Forms.MetroForm
    {
        public frmSupplierAccountStatement()
        {
            InitializeComponent();
        }
        private static frmSupplierAccountStatement _instance;

        public static frmSupplierAccountStatement Instance { get { if (_instance == null) _instance = new frmSupplierAccountStatement(); return _instance; } }
    }
}
