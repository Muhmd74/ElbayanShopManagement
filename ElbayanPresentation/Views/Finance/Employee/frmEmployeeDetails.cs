using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Finance.Employee
{
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
            _instance = this;
        }
        private static frmEmployeeDetails _instance;
        public static frmEmployeeDetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmEmployeeDetails();
                return _instance;
            }
        }
    }
}
