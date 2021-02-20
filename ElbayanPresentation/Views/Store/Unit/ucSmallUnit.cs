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

namespace ElbayaNPresentation.Views.Store.Unit
{
    public partial class ucSmallUnit : DevExpress.XtraEditors.XtraUserControl
    {
        public ucSmallUnit()
        {
            InitializeComponent();
            
        }
        private static ucSmallUnit _instance;
        public static ucSmallUnit Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSmallUnit();
                return _instance;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }
    }
}
