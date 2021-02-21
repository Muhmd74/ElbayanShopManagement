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

            nupSmallUnitWeight.Controls[0].Visible = false;

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
        public decimal Weight { get => nupSmallUnitWeight.Value; set=> nupSmallUnitWeight.Value = value; }
        public string SearchKeyword { get => txtSearch.Text; set => txtSearch.Text = value; }
        public Guid LargeUnitID { get => new Guid (cbxLargeUnit.SelectedValue.ToString()); set => cbxLargeUnit.SelectedValue = value; }
        public string LargeUnitName { get; set; }
        public List<SmallUnitDto> SmallUnits { get; set; }
        public List<LargeUnitDto> LargeUnit { get; set; }
        public SmallUnitPresenter Presenter { private get; set; }

        public void PopulatecbxLargeUnit()
        {
            // Pupulate Main category in combo box
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
                    cbxLargeUnit.Text = "";
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
    }
}
