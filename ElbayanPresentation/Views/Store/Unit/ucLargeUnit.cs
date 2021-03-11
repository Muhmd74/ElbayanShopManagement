using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Store.Unit.LargeUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
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

namespace ElbayaNPresentation.Views.Store.Units
{
    public partial class ucLargeUnits : DevExpress.XtraEditors.XtraUserControl, IViewLargeUnit
    {
        public ucLargeUnits()
        {
            InitializeComponent();
           
            Presenter = new LargeUnitPresenter(this);
            _instance = this;
            // load Active Units list
            Presenter.OnLoadUC();
        }

        protected override void OnLoad(EventArgs e) 
        { 
            base.OnLoad(e);

        }
            // Apply singlton pattern for form Instance
        private static ucLargeUnits _instance;
        public static ucLargeUnits Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLargeUnits();
                return _instance;
            }
        }

        public Guid ID { get; set; }
        public Guna2TextBox LargeUnitName { get => txtName; set => txtName = value; }
        public Guna2TextBox LargeUnitDescirption { get => txtDescription; set => txtDescription = value; }
        public Guna2TextBox SearchTextBox { get => txtSearch; set => txtSearch = value; }
        public DataGridView ActiveObject { get => dgvLargeUnit; set => dgvLargeUnit = value; }
        public DataGridView DeletedObject { get => dgvDeletedLargeUnit; set => dgvDeletedLargeUnit = value; }
        public Guna2Button UpdateObject { get => btnUpdate; set => btnUpdate = value; }
        public Guna2Button DeleteObject { get => btnDeleteByOne; set => btnDeleteByOne = value; }
        public Guna2Button AddObject { get => btnAdd; set => btnAdd = value; }
        public TabControl DGVTabControl { get => dgvTabContainer; set => dgvTabContainer = value; }
        public LargeUnitPresenter Presenter { get; set ; }
 
        private void btnAdd_Click(object sender, EventArgs e)
        {
                Presenter.AddNewUnit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Presenter.OnClickUpdatebtn();
        }

        private void btnDeleteByOne_Click(object sender, EventArgs e)
        {
            Presenter.DeletedOrRestore();
        }

        private void dgvLargeUnit_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickActiveObjectDGV();
        }

        private void dgvDeletedLargeUnit_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickDeletedObjectDGV();
        }

        private void dgvTabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.OnSelectedIndexChangedTabCOntrol();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Presenter.OnTextChangedSearch();
        }
    }
}
