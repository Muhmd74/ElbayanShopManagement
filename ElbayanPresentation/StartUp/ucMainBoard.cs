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

namespace ElbayaNPresentation.StartUp
{
    public partial class ucMainBoard : DevExpress.XtraEditors.XtraUserControl
    {
        public ucMainBoard()
        {
            InitializeComponent();
            _instance = this;
        }
        private static ucMainBoard _instance;
        public static ucMainBoard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMainBoard();
                return _instance;
            }
        }
    }
}
