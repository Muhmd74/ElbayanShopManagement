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

namespace ElbayaNPresentation.Views.Store.Product
{
    public partial class AllProductsView : DevExpress.XtraEditors.XtraUserControl
    {
        public AllProductsView()
        {
            InitializeComponent();
        }
        private static AllProductsView _instance;
        public static AllProductsView Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AllProductsView();
                return _instance;
            }
        }
    }
}
