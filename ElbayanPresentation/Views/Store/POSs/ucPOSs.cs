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

namespace ElbayaNPresentation.Views.Store.POSs
{
    public partial class ucPOSs : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPOSs()
        {
            InitializeComponent();
        }

        private static ucPOSs _instance;

        public static ucPOSs Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ucPOSs();
                }
                return _instance;
            }
        }
    }
}
