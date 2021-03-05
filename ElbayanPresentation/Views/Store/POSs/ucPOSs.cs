using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.Store.Building.POS;
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

namespace ElbayaNPresentation.Views.Store.POSs
{
    public partial class ucPOSs : DevExpress.XtraEditors.XtraUserControl, IViewPOS
    {
        public ucPOSs()
        {
            InitializeComponent();
            _instance = this;

            Presenter = new POSPresenter(this);
            Presenter.OnloadUC();
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

        public Guid POSsId { get; set; }
        public Guna2TextBox POSsName { get => txtName; set => txtName = value; }
        public Guna2TextBox POSsShortCode { get => txtPionShortCode; set => txtPionShortCode = value; }
        public Guna2ComboBox Buidling { get => cbxBuilding; set => cbxBuilding = value; }
        public Guna2TextBox SearchtxtBox { get => txtSearch; set => txtSearch = value; }
        DataGridView IViewPOS.dgvActiveObjects { get => dgvActiveObjects; set => dgvActiveObjects = value; }
        DataGridView IViewPOS.dgvDeletedObjects { get => dgvDeletedObjects; set => dgvDeletedObjects = value; }
        public Guna2Button btnAddObject { get => btnAdd; set => btnAdd = value; }
        public Guna2Button btnUpdateObject { get => btnUpdate; set => btnUpdate = value; }
        public Guna2Button btnDeleteObject { get => btnDeleteByOne; set => btnDeleteByOne = value; }
        public TabControl dgvContainer { get => dgvTabContainer; set => dgvTabContainer = value; }
        public POSPresenter Presenter { get; set ; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnAdd();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnUpdate();
        }

        private void cbxBuilding_Click(object sender, EventArgs e)
        {
            Presenter.PopulatecbxBuilind();
        }

        private void dgvActiveObjects_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoublClickdgvActiveObject();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Presenter.OnTextChnagedtxtSearch();
        }
    }
}
