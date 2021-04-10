using ElbayaNPresentation.Presenters.Store.Product.ProductOpeningBalance;
using Guna.UI2.WinForms;
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
    public partial class frmProductOpeningBalance : MetroFramework.Forms.MetroForm, IViewProductOpeningBakance
    {
        public frmProductOpeningBalance()
        {
            InitializeComponent();
            _insatnce = this;
            Presenter = new PresenterProductOpeneingBalance(this);
            Presenter.OnLOad();
        }
        private static frmProductOpeningBalance _insatnce;
        public static frmProductOpeningBalance Insatnce
        {
            get
            {
                if (_insatnce == null)
                    _insatnce = new frmProductOpeningBalance();
                return _insatnce;
            }
        }
        public ComboBox ActiveProduct { get => cbxActiveProduct; set => cbxActiveProduct = value; }
        public Guna2TextBox ProductStock { get => txtProductQuantity; set => txtProductQuantity = value; }
        public Guna2Button AddObject { get => btnSave; set => btnSave = value; }
        public PresenterProductOpeneingBalance Presenter { get; set; }
        public Label AvailableQuantity { get => lblAvailableQuantity; set => lblAvailableQuantity = value; }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
