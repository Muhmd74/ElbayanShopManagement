using ElbayaNPresentation.Presenters.Finance.Employee.ALLEmployee;
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

namespace ElbayaNPresentation.Views.Finance.Employee
{
    public partial class ucAllEmployeeData : UserControl, IViewAllEmployee
    {
        public ucAllEmployeeData()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new PresenterAllEmployee(this);
            Presenter.OnLoadUc();
        }
        private static ucAllEmployeeData _instance;
        public static ucAllEmployeeData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAllEmployeeData();
                return _instance;
            }
        }

        public Guid ID { get; set; }
        public Guna2TextBox SearchTextBox { get => txtSearchBox; set => txtSearchBox = value; }
        public Guna2Button AddObject { get => btnAdd; set => btnAdd = value; }
        public DataGridView ActiveObject { get => dgvActiveObjects; set => dgvActiveObjects = value; }
        public DataGridView NotActiveObject { get => dgvDeletedObjects; set => dgvDeletedObjects = value; }
        public TabControl TabContainer { get => tabDGVContainer; set => tabDGVContainer = value; }
        public PresenterAllEmployee Presenter { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails.Instance.Presenter.ClearControl();
            frmEmployeeDetails.Instance.ShowDialog();
        }

        private void dgvActiveObjects_DoubleClick(object sender, EventArgs e)
        {
            Presenter.ActiveObjectDGV_DoubleClick();
        }
    }
}
