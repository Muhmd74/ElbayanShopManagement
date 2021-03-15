using DevExpress.XtraEditors;
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
        Guna2TextBox TotalOrder { get; set; }
        Guna2TextBox TotalProductInOrder { get; set; }
        SimpleButton NewSupplier { get; set; }
        SimpleButton NewProduct { get; set; }
        SimpleButton DeleteProductFromOrder { get; set; }
        Guna2DateTimePicker OrderDate { get; set; }
        Guna2DateTimePicker OrderDeferredDate { get; set; }
        System.Windows.Forms.ComboBox Suppliers { get; set; }
        System.Windows.Forms.ComboBox Products { get; set; }
        RadioButton IsDeferred { get; set; }
        RadioButton IsCash { get; set; }
        LabelControl UserNam { get; set; }
        DataGridView OrderProduct { get; set; }
    }
}
