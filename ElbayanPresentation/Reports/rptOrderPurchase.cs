using DevExpress.XtraReports.UI;
using ElbayanServices.Repository.Clints.OrderProcurement;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ElbayaNPresentation.Reports
{
    public partial class rptOrderPurchase : DevExpress.XtraReports.UI.XtraReport
    {
        public rptOrderPurchase()
        {
            InitializeComponent();
        }
        private static OrderProcurementService Invoice = new OrderProcurementService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public void PrintOrder(Guid ID)
        {
            rptOrderPurchase rpt = new rptOrderPurchase();
            var ds = Invoice.PrintInvoice(ID);
            rpt.DataSource = ds;
            rpt.DetailReport.DataSource = ds;
            rpt.DetailReport.DataMember = "productOrder";
            xtcorderNumber.DataBindings.Add("Text", ds, "OrderNumber");
            rpt.ShowPreview();
        }

        void BindingData()
        {

        }


    }
}
