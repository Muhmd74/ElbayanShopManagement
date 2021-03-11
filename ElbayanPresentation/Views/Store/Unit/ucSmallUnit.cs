using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Store.Unit.SmallUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
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

namespace ElbayaNPresentation.Views.Store.Unit
{
    public partial class ucSmallUnit : DevExpress.XtraEditors.XtraUserControl, IViewSmallUnit
    {
        public ucSmallUnit()
        {
            InitializeComponent();
            Presenter = new SmallUnitPresenter(this);
            Presenter.OnLoadUC();
        }
        private static ucSmallUnit _instance;
        public static ucSmallUnit Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSmallUnit();
                return _instance;
            }
        }

        public Guid ID { get ; set; }
        public Guna2TextBox SmallUnitName { get => txtName; set => txtName = value; }
        public Guna2TextBox Description { get => txtDescription; set => txtDescription = value; }
        public NumericUpDown Weight { get => nudSmallUnitWeight; set => nudSmallUnitWeight = value; }
        public Guna2TextBox SearchKeyword { get => txtSearch; set => txtSearch = value; }
        public Guna2ComboBox LargeUnit { get => cbxLargeUnit; set => cbxLargeUnit = value; }
        public DataGridView ActiveObject { get => dgvSmallUnit; set => dgvSmallUnit = value; }
        public DataGridView DeletedObject { get => dgvDeletedSmallUnit; set => dgvDeletedSmallUnit = value; }
        public Guna2Button UpdateObject { get => btnUpdate; set => btnUpdate = value; }
        public Guna2Button DeleteObject { get => btnDeleteByOne; set => btnDeleteByOne = value; }
        public Guna2Button AddObject { get => btnAdd; set => btnAdd = value; }
        public TabControl DGVTabControl { get => dgvTabContainer; set => dgvTabContainer = value; }
        public SmallUnitPresenter Presenter { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnAdd();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Presenter.OnclickUpdate();
        }

        private void btnDeleteByOne_Click(object sender, EventArgs e)
        {
            Presenter.onClickbtnDelete();
        }

        private void dgvSmallUnit_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickActiveDGv();
        }

        private void dgvTabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.OnSelectedIndexChangedTabContainer();
        }

        private void dgvDeletedSmallUnit_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickDeletedDGv();
        }

        private void cbxLargeUnit_Click(object sender, EventArgs e)
        {
            Presenter.PopulatecbxLargeUnit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Presenter.OnTextChangedSearch();
        }
    }
}
