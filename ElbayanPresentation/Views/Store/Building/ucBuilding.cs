using DevExpress.XtraEditors;
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

        public Guna2TextBox BuildingName { get => txtName; set => txtName = value; }
        public Guna2TextBox BuildingDescription { get => txtDescription; set => txtDescription = value; }
        public Guna2TextBox BuildingAddress { get => txtAddress; set => txtAddress = value; }
        public Guna2TextBox BuildingAddressPhoneNumber { get => txtPhoneNumber; set => txtPhoneNumber = value; }
        public Guna2TextBox SearchtxtBox { get => txtSearch; set => txtSearch = value; }
        DataGridView IViewBuilding.dgvActiveObjects { get => dgvActiveObjects; set => dgvActiveObjects = value; }
        DataGridView IViewBuilding.dgvDeletedObjects { get => dgvDeletedObjects; set => dgvDeletedObjects = value; }
        public BuildingPresenter Presenter { get; set; }
    }
}
