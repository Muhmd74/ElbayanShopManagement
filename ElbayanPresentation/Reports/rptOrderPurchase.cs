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
            xrFirmName.DataBindings.Add("Text", this.DataSource, "FirmName");
            xrFirmePhone.DataBindings.Add("Text", this.DataSource, "Phone");
            xrpbLogo.DataBindings.Add("ImageUrl", this.DataSource, "LogoInvoice");
            xrlblInvoiceType.DataBindings.Add("Text", this.DataSource, "OrderType");
            xtcorderNumber.DataBindings.Add("Text", this.DataSource, "OrderNumber");
            xrlblOrderDate.DataBindings.Add("Text", this.DataSource, "DateTime");
            xrlblSupplierName.DataBindings.Add("Text", this.DataSource, "ClintName");
            xrlblUserName.DataBindings.Add("Text", this.DataSource, "EmployeeName");
            xrlblPOS.DataBindings.Add("Text", this.DataSource, "PosName");

            //xtcOrderProductName.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "+1"));
            xtcOrderProductName.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "ProductName"));
            xtOrderProductUnit.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "UnitName"));
            xtcOrderProductQantity.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "Quantity"));
            xtcOrderProductPrice.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "Price"));
            xtcOrderProductTotal.ExpressionBindings.Add(new ExpressionBinding("BeforePrint","Text", "Quantity * Price"));

            xrcTotalOrder.DataBindings.Add("Text", this.DataSource, "TotalAfterDiscount");
            xrcTotalDiscount.DataBindings.Add("Text", this.DataSource, "TotalDiscount");
            xrcPayment.DataBindings.Add("Text", this.DataSource, "Payment");
            xrcDeferred.DataBindings.Add("Text", this.DataSource, "DeferredPrice");

            xrLblNote.DataBindings.Add("Text", this.DataSource, "MessageInvoice");
            xrBcOrderNumber.DataBindings.Add("Text", this.DataSource, "OrderNumber");
        }


    }
}
