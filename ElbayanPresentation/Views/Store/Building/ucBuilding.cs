using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Store.Building;
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

namespace ElbayaNPresentation.Views.Store.Building
{
    public partial class ucBuilding : DevExpress.XtraEditors.XtraUserControl, IViewBuilding
    {
        public ucBuilding()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new BuildingPresenter(this);

            // Load Data:
            Presenter.OnloadUCBuilding();
        }

        private static ucBuilding _instance;
        public static ucBuilding Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBuilding();
                return _instance;
            }
        }

        public Guid BuildingId { get; set; }
        public Guna2TextBox BuildingName { get => txtName; set => txtName = value; }
        public Guna2TextBox BuildingDescription { get => txtDescription; set => txtDescription = value; }
        public Guna2TextBox BuildingAddress { get => txtAddress; set => txtAddress = value; }
        public Guna2TextBox BuildingPhoneNumber { get => txtPhoneNumber; set => txtPhoneNumber = value; }
        public Guna2TextBox SearchtxtBox { get => txtSearch; set => txtSearch = value; }
        DataGridView IViewBuilding.dgvActiveObjects { get => dgvActiveObjects; set => dgvActiveObjects = value; }
        DataGridView IViewBuilding.dgvDeletedObjects { get => dgvDeletedObjects; set => dgvDeletedObjects = value; }
        public BuildingPresenter Presenter { get; set; }
        public Guna2Button btnAddObject { get => btnAdd; set => btnAdd = value; }
        public Guna2Button btnUpdateObject { get => btnUpdate; set => btnUpdate = value; }
        public Guna2Button btnDeleteObject { get => btnDeleteByOne; set => btnDeleteByOne = value; }
        public TabControl dgvContainer { get => dgvTabContainer; set => dgvTabContainer = value; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.CreateNewObject();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateControls.ValidateTextBoxOnlyNumber(sender, e, txtPhoneNumber);
            this.txtPhoneNumber.MaxLength = 14;
        }

        private void dgvActiveObjects_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoublClickdgvActiveObject();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnUpdate();
        }

        private void btnDeleteByOne_Click(object sender, EventArgs e)
        {
            Presenter.OnClickbtnDelete();
        }

        private void dgvDeletedObjects_DoubleClick(object sender, EventArgs e)
        {
            Presenter.OnDoubleClickdgvDeletedObject();
        }

        private void dgvTabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.OnIndexChangedTabContainer();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Presenter.OnTextChnagedtxtSearch();
        }
    }
}
