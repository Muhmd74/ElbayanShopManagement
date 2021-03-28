using DevExpress.XtraReports.UI;
using ElbayanServices.Repository.Products.Product;
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
        private readonly ProductService Product = new ProductService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public static void PrintOrder(object ds)
        {
            rptOrderPurchase rpt = new rptOrderPurchase();
            rpt.DataSource = ds;
            rpt.DetailReport.DataSource = ds;
            rpt.DetailReport.DataMember = "";

            rpt.ShowPreview();
        }


    }
}
