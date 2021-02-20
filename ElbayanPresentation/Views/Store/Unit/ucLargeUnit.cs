using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Store.Unit.LargeUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
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
            
            // 
            Presenter = new LargeUnitPresenter(this);
            // load Active Units list
            PopulateAllUnitDataGridView();

            btnUpdate.Enabled = false;
            btnDeleteByOne.Enabled = false;
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
        

        // Implement IView Latge Unit.
        public string LargeUnitName { get => txtName.Text; set => txtName.Text = value; }
        public string LargeUnitDescirption { get => txtDescription.Text; set => txtDescription.Text = value; }
        public string SearchKeyword { get => txtSearch.Text; set => txtSearch.Text = value; }
        public Guid LargeUnitID { get; set; }
        public List<LargeUnitDto> LargeUnit { get; set; }
        public LargeUnitPresenter Presenter { private get;  set; }

        public void PopulateAllUnitDataGridView()
        {

            if (Presenter.GetAllLargeUnit().Any())
            {
                dgvLargeUnit.DataSource = Presenter.GetAllLargeUnit();
            }
            else
            {
                dgvLargeUnit.DataSource = null;
            }

            /// Notes: columns[0] == Name
            //dgvLargeUnit.Columns[2].Visible = true;
            //dgvLargeUnit.Columns[3].Visible = true;
            DataGridViewStyle.StyleDatagridview(dgvLargeUnit);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                Presenter.AddNewUnit();
                MessageBox.Show("تمت عملية الإضافة بنجاح", "تأكيد", MessageBoxButtons.OK);
                txtName.Clear();
                txtDescription.Clear();
                dgvLargeUnit.DataSource = Presenter.GetAllLargeUnit();
            }
            else
            {
                MessageBox.Show("لا بد من إدخال اسم الوحدة", "تأكيد", MessageBoxButtons.OK);
                return;
            }

        }

        private void dgvLargeUnit_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLargeUnit.CurrentRow.Index != -1)
            {
                txtName.Text = dgvLargeUnit.CurrentRow.Cells["dgvLargeUnitName"].Value.ToString();
                txtDescription.Text = dgvLargeUnit.CurrentRow.Cells["dgvLargeUnitDescription"].Value.ToString();
                LargeUnitID = new Guid(dgvLargeUnit.CurrentRow.Cells["dgvLargeUnitID"].Value.ToString());

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDeleteByOne.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                Presenter.OnClickUpdatebtn(LargeUnitID);
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                txtName.Clear();
                txtDescription.Clear();
                dgvLargeUnit.DataSource = Presenter.GetAllLargeUnit();

                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDeleteByOne.Enabled = false;
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void dgvTabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dgvTabContainer.SelectedIndex == 0)
            {
                PopulateAllUnitDataGridView();

                txtDescription.Text = txtName.Text = txtSearch.Text = string.Empty;
                btnAdd.Enabled = true;
                btnDeleteByOne.Text = "أرشفة الوحدة";
                btnUpdate.Enabled = false;
                btnDeleteByOne.Enabled = false;
            }
            else if (dgvTabContainer.SelectedIndex == 1)
            {
                dgvDeletedLargeUnit.DataSource = Presenter.GetAllDeltetdUnits();
                dgvDeletedLargeUnit.Columns[2].Visible = false;
                DataGridViewStyle.StyleDatagridview(dgvDeletedLargeUnit);

                btnAdd.Enabled = false;
                btnDeleteByOne.Text = "إستعادة الوحدة";
                btnUpdate.Enabled = false;
                btnDeleteByOne.Enabled = true;
                txtDescription.Text = txtName.Text = txtSearch.Text = string.Empty;
            }
        }

        private void btnDeleteByOne_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                Presenter.DeletedOrRestore(LargeUnitID);
                txtName.Clear();
                txtDescription.Clear();
                if (dgvTabContainer.SelectedIndex == 1)
                {
                    dgvDeletedLargeUnit.DataSource = Presenter.GetAllDeltetdUnits();
                }
                else
                {
                    dgvLargeUnit.DataSource = Presenter.GetAllLargeUnit();
                }
                MessageBox.Show("تمت العملية بنجاح", "تأكيد", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void dgvDeletedLargeUnit_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDeletedLargeUnit.CurrentRow.Index != -1)
            {
                txtName.Text = dgvDeletedLargeUnit.CurrentRow.Cells["dgvLargeUnitDeletedName"].Value.ToString();
                txtDescription.Text = dgvDeletedLargeUnit.CurrentRow.Cells["dgvLargeUnitDeletedName"].Value.ToString();
                LargeUnitID = new Guid(dgvDeletedLargeUnit.CurrentRow.Cells["dgvLargeUnitDeletedID"].Value.ToString());
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if(dgvTabContainer.SelectedIndex == 0)
            {
                dgvLargeUnit.DataSource = Presenter.FilterDataGridView().ToList();
            }else if (dgvTabContainer.SelectedIndex == 1)
            {
                dgvDeletedLargeUnit.DataSource = Presenter.FilterDataGridViewDeleted();
            }
        }
    }
}
