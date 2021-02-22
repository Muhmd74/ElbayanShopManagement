using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Store.Unit.SmallUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
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

            nudSmallUnitWeight.Controls[0].Visible = false;

            PopulateAllUnitDataGridView();

            PopulatecbxLargeUnit();

          
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

        public Guid SmallUnitID { get; set; }
        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public string SmallUnitName { get => txtName.Text; set => txtName.Text = value; }
        public decimal Weight { get => nudSmallUnitWeight.Value; set=> nudSmallUnitWeight.Value = value; }
        public string SearchKeyword { get => txtSearch.Text; set => txtSearch.Text = value; }
        public Guid LargeUnitID { get => new Guid (cbxLargeUnit.SelectedValue.ToString()); set => cbxLargeUnit.SelectedValue = value; }
        public string LargeUnitName { get; set; }
        public List<SmallUnitDto> SmallUnits { get; set; }
        public List<LargeUnitDto> LargeUnit { get; set; }
        public SmallUnitPresenter Presenter { private get; set; }

        public void PopulatecbxLargeUnit()
        {
            // Pupulate Main category in combo box

            cbxLargeUnit.DataSource = null;
            cbxLargeUnit.Items.Clear();
            cbxLargeUnit.DataSource = Presenter.FillcbxLargeUnit();
            cbxLargeUnit.DisplayMember = "Name";
            cbxLargeUnit.ValueMember = "Id";
            cbxLargeUnit.SelectedValue = "Id";
        }
        public void PopulateAllUnitDataGridView()
        {

            if (Presenter.GetAllSmallUnit().Any())
            {
                dgvSmallUnit.DataSource = Presenter.GetAllSmallUnit();
            }
            else
            {
                dgvSmallUnit.DataSource = null;
            }
            dgvSmallUnit.AutoGenerateColumns =false;
            DataGridViewStyle.StyleDatagridview(dgvSmallUnit);
            //dgvSmallUnit.Columns[6].Visible = false;
            //dgvSmallUnit.Columns[5].Visible = false;
            //dgvSmallUnit.Columns[0].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                if (cbxLargeUnit.SelectedItem != null)
                {

                    Presenter.OnClickbtnAdd();
                    MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                    txtName.Clear();
                    txtDescription.Clear();
                    nudSmallUnitWeight.Value = 1.00m;
                    cbxLargeUnit.Refresh();
                    
                    dgvSmallUnit.DataSource = Presenter.GetAllSmallUnit();
                }
                else
                {
                    MessageBox.Show("كرما أختر قيمة تصنيف رئيس", "تأكيد", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("لا بد من إدخال اسم التصنيف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void dgvSmallUnit_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSmallUnit.CurrentRow.Index != -1)
            {
                btnAdd.Enabled = false;
                txtName.Text = dgvSmallUnit.CurrentRow.Cells["dgvSmallUnitName"].Value.ToString();
                txtDescription.Text = dgvSmallUnit.CurrentRow.Cells["dgvSmallUnitDescription"].Value.ToString();
                nudSmallUnitWeight.Text = dgvSmallUnit.CurrentRow.Cells["dgvSmallUnitWeight"].Value.ToString();
                SmallUnitID = new Guid(dgvSmallUnit.CurrentRow.Cells["dgvSmallUnitID"].Value.ToString());
                LargeUnitID = new Guid(dgvSmallUnit.CurrentRow.Cells["dgvLargeUnitIDForSmallUnitActive"].Value.ToString());
                // dgvMainCategoryName
                LargeUnitName = dgvSmallUnit.CurrentRow.Cells["dgvLargeUnitNameForSmallUnitActive"].Value.ToString();
                cbxLargeUnit.Text = LargeUnitName;
            }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                if (cbxLargeUnit.SelectedItem != null)
                {
                    Presenter.OnclickUpdate(SmallUnitID, LargeUnitID);
                    MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
                    btnAdd.Enabled = true;
                    btnDeleteByOne.Enabled = true;
                    cbxLargeUnit.Text = txtDescription.Text = txtName.Text = "";
                    nudSmallUnitWeight.Value = 1.00m;
                    dgvSmallUnit.DataSource = Presenter.GetAllSmallUnit();
                }
                else
                {
                    MessageBox.Show("كرما أختر قيمة تصنيف رئيس", "تأكيد", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("لا بد من إدخال اسم التصنيف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void dgvTabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvTabContainer.SelectedIndex == 0)
            {
                dgvSmallUnit.DataSource = Presenter.GetAllSmallUnit();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                cbxLargeUnit.Enabled = true;
            }
            else if (dgvTabContainer.SelectedIndex == 1)
            {
                DataGridViewStyle.StyleDatagridview(dgvDeletedSmallUnit);
                dgvDeletedSmallUnit.DataSource = Presenter.GetAllSmallUnitDeleted();
                btnAdd.Enabled = false;
                //btnUpdate.Enabled = false;
                //cbxMainCategory.Enabled = false;
            }
        }

        private void dgvDeletedSmallUnit_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDeletedSmallUnit.CurrentRow.Index != -1)
            {


                btnAdd.Enabled = false;
                txtName.Text = dgvDeletedSmallUnit.CurrentRow.Cells["dgvSmallUnitNameDeleted"].Value.ToString();
                txtDescription.Text = dgvDeletedSmallUnit.CurrentRow.Cells["dgvSmallUnitDescriptionDeleted"].Value.ToString();
                nudSmallUnitWeight.Text = dgvDeletedSmallUnit.CurrentRow.Cells["dgvSmallUnitWeightDeleted"].Value.ToString();
                SmallUnitID = new Guid(dgvDeletedSmallUnit.CurrentRow.Cells["dgvSmallUnitIDDeleted"].Value.ToString());
                LargeUnitID = new Guid(dgvDeletedSmallUnit.CurrentRow.Cells["dgvLargeUnitIDForSmallUnitDeleted"].Value.ToString());
                // dgvMainCategoryName
                LargeUnitName = dgvDeletedSmallUnit.CurrentRow.Cells["dgvLargeUnitNameForSmallUnitDeleted"].Value.ToString();
                cbxLargeUnit.Text = LargeUnitName;

            }
        }

        private void btnDeleteByOne_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                Presenter.onClickbtnDelete(SmallUnitID);
                txtName.Clear();
                txtDescription.Clear();
                nudSmallUnitWeight.Value = 1.00m;
                if (dgvTabContainer.SelectedIndex == 1)
                {
                    dgvDeletedSmallUnit.DataSource = Presenter.GetAllSmallUnitDeleted();
                }
                else if (dgvTabContainer.SelectedIndex == 0)
                {
                    dgvSmallUnit.DataSource = Presenter.GetAllSmallUnit();
                }
                MessageBox.Show("تمت عملية الإضافة بناجاح", "تأكيد", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("لا بد من تحديد صف من البيانات من خلال الضغط مرتين على الصف", "تأكيد", MessageBoxButtons.OK);
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvTabContainer.SelectedIndex == 0)
            {
                dgvSmallUnit.DataSource = Presenter.FilterDataGridView().ToList();
            }
            else if (dgvTabContainer.SelectedIndex == 1)
            {
                dgvDeletedSmallUnit.DataSource = Presenter.FilterDataGridViewDeleted();
            }
        }

        private void cbxLargeUnit_Click(object sender, EventArgs e)
        {
            PopulatecbxLargeUnit();
        }
    }
}
