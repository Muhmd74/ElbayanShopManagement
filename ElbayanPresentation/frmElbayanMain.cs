using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayanPresentation
{
    public partial class frmElbayanMain : Form
    {
        public frmElbayanMain()
        {
            InitializeComponent();
            // StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            int h = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = new Point(0,0);
            this.Size = new Size(w, h);
        }

        private void frmElbayanMain_Load(object sender, EventArgs e)
        {

        }
    }
}
