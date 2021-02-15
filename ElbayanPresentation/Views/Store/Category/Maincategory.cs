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

namespace ElbayaNPresentation.Views.Store.Category
{
    public partial class Maincategory : DevExpress.XtraEditors.XtraUserControl
    {
        private static Maincategory _instance;
        public static Maincategory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Maincategory();
                return _instance;
            }
        }
        public Maincategory()
        {
            InitializeComponent();
        }
    }
}
