﻿using DevExpress.XtraEditors;
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
        public List<LargeUnitDto> LargeUnit { get; set; }
        public LargeUnitPresenter Presenter { private get;  set; }

        public void PopulateAllUnitDataGridView()
        {
            dgvLargeUnit.DataSource = Presenter.GetAllLargeUnit();
            dgvLargeUnit.Columns[0].Visible = false;
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
    }
}
