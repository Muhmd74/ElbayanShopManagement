using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Purchases.ProcurementOrder
{
    public interface IViewProcurementOrder
    {
        Guid ID { get; set; }
        PresenterProcurementOrder Presenter { get; set; }
        Guna2TextBox OrderNumber { get; set; }
        Guna2TextBox BareCode { get; set; }
        Guna2TextBox TotalOrderWithoutDiscount { get; set; }
        Guna2TextBox TotalOrderDiscount { get; set; }
        Guna2TextBox TotalOrderWithDiscount { get; set; }
        Guna2TextBox TotalOrderWithoutVAT { get; set; }
        Guna2TextBox TotalOrderVAT { get; set; }
        Guna2TextBox Paid { get; set; }
        Guna2TextBox Deferred { get; set; }
        Guna2Button NewSupplier { get; set; }
        Guna2TextBox SupplierMobile { get; set; }
        Guna2Button AddNewProductDGV { get; set; }
        Guna2Button DeleteProductFromOrder { get; set; }
        Guna2Button UpdateProudctQuantity { get; set; }
        Guna2Button SaveOrder { get; set; }
        Guna2Button PrintOrder { get; set; }
        Guna2Button NewOrder { get; set; }
        Guna2Button BackTo { get; set; }
        Guna2DateTimePicker OrderDate { get; set; }
        Guna2DateTimePicker OrderDeferredDate { get; set; }
        ComboBox Suppliers { get; set; }
        ComboBox Products { get; set; }
        CheckBox IsDeferred { get; set; }
        Guna2TextBox UserName { get; set; }
        DataGridView OrderProduct { get; set; }
    }
}
