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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUserName.Select();
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewProductDGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainBoard.Instance.ShowDialog();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            cbViewPassword.Checked = false;
        }

         private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }


        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            this.txtPassword.Focus();
            if (txtPassword.Focused)
            {
                txtPassword.BackColor = Color.White;
                panel4.BackColor = Color.White;
                panel3.BackColor = SystemColors.Control;
                txtUserName.BackColor = SystemColors.Control;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Focused)
            {
                txtUserName.BackColor = Color.White;
                panel3.BackColor = Color.White;
                panel4.BackColor = SystemColors.Control;
                txtPassword.BackColor = SystemColors.Control;
            }
        }
    }
}
