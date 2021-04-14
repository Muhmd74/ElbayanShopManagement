using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Client
{
    public partial class frmPayDebit : MetroFramework.Forms.MetroForm
    {
        public frmPayDebit()
        {
            InitializeComponent();
        }
        private static frmPayDebit _instance;

        public static frmPayDebit Instance { get { if (_instance == null) _instance = new frmPayDebit(); return _instance; } }

        private void frmPayDebit_Load(object sender, EventArgs e)
        {
            this.dtpPaymentDate.Value = DateTime.Now;
            this.ActiveControl = txtPayment;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
