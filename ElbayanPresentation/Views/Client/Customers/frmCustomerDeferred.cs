using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Client.Customers
{
    public partial class frmCustomerDeferred : MetroFramework.Forms.MetroForm
    {
        public frmCustomerDeferred()
        {
            InitializeComponent();
            _instance = this;
        }
        private static frmCustomerDeferred _instance;

        public static frmCustomerDeferred Instance { get { if (_instance == null) _instance = new frmCustomerDeferred(); return _instance; } }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPayDebit.Instance.ShowDialog();
        }
    }
}
