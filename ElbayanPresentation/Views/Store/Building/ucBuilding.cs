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

namespace ElbayaNPresentation.Views.Store.Building
{
    public partial class ucBuilding : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBuilding()
        {
            InitializeComponent();
            _instance = this;
        }

        private static ucBuilding _instance;
        public static ucBuilding Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBuilding();
                return _instance;
            }
        }
    }
}
