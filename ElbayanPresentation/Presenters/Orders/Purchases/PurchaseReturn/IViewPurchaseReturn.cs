using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Orders.Purchases.PurchaseReturn
{
    public interface IViewPurchaseReturn
    {
        PresenterPurchaseReturn Presenter { get; set; }
        Label SupplierName { get; set; }
        Label POSName { get; set; }
        Label UserName { get; set; }
        RadioButton IsOnlyOneProduct { get; set; }
        NumericUpDown ReturnAmountOfProduct { get; set; }
        DataGridView OrderProducts { get; set; }
        Guna2TextBox SearchText { get; set; }
        Guna2TextBox TotalOrder { get; set; }
        Guna2TextBox OrderDeferred { get; set; }
        Guna2TextBox OrderPayment { get; set; }
        Guna2TextBox TotalOrderVAT { get; set; }
        Guna2TextBox CollectedPersonName { get; set; }
        Guna2TextBox CollectedPersonMobile { get; set; }
        Guna2TextBox CollectedPersonJob { get; set; }
        Guna2DateTimePicker ReturndateTime { get; set; }
        Guna2Button Close { get; set; }
        Guna2Button ReturnAllOrderProduct { get; set; }
        Guna2Button ReturnSelectedProduct { get; set; }
        Guna2Button ReturnSpicificquantitySelectedProduct { get; set; }
    }
}
