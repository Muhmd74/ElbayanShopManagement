using ElbayaNPresentation.Views.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Purchases.Suppliers
{
    public partial class frmSupplierDebits : MetroFramework.Forms.MetroForm
    {
        public frmSupplierDebits()
        {
            InitializeComponent();
            _instance = this;
        }
        private static frmSupplierDebits _instance;

        public static frmSupplierDebits Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmSupplierDebits();
                return _instance;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPayDebit.Instance.ShowDialog();
        }
    }

}
