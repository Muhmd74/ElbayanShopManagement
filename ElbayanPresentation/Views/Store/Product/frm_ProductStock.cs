using ElbayaNPresentation.Presenters.Store.Product.ProductStock;
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
    public partial class frm_ProductStock : MetroFramework.Forms.MetroForm, IViewProductStoc
    {
        public frm_ProductStock()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new PresenterProductStock(this);
            Presenter.OnLoad();
        }
        private static frm_ProductStock _instance;
        public static frm_ProductStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frm_ProductStock();
                return _instance;
            }
        }

        public PresenterProductStock Presenter { get; set; }
        public Guna2TextBox ProductBarCode { get => txtProductBarcode; set => txtProductBarcode = value; }
        public ComboBox ActiveProduct { get => cbxActiveProduct; set => cbxActiveProduct = value; }
        public ComboBox ProcessType { get => cbxOrderType; set => cbxOrderType = value; }
        public Guna2DateTimePicker StartDate { get => dtpStartDate; set => dtpStartDate = value; }
        public Guna2DateTimePicker EndDate { get => dtpEndDate; set => dtpEndDate = value; }
        public Guna2Button Search { get => btnSearch; set => btnSearch = value; }
        public DataGridView SearchResult { get => dgvSearchResult; set => dgvSearchResult = value; }
    }
}
