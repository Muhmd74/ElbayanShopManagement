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
        public static void PrintOrder(object ds)
        {
            rptOrderPurchase rpt = new rptOrderPurchase();
            rpt.DataSource = ds;
            rpt.DetailReport.DataSource = rpt.DataSource;
            rpt.DetailReport.DataMember = "Products";
            rpt.BindingData();
            //rpt.ShowPreview();
            rpt.PrintDialog();
        }

        void BindingData()
        {
            xtcorderNumber.DataBindings.Add("Text", this.DataSource, "OrderNumber");


            //xtcOrderProductName.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "+1"));
            xtcOrderProductName.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "ProductName"));
            xtOrderProductUnit.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "UnitName"));
            xtcOrderProductQantity.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "Quantity"));
            xtcOrderProductPrice.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "Price"));
            xtcOrderProductTotal.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "Quantity * Price"));
        }


    }
}
