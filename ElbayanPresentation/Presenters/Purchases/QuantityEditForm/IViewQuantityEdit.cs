using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Purchases.QuantityEditForm
{
    public interface IViewQuantityEdit
    {
        Guid ID { get; set; }
        decimal Vat { get; set; }
        PresenterQuantityEdit Presenter { get; set; }
        Guna2TextBox Quantity { get; set; }
        Guna2TextBox DefaultPrice { get; set; }
        Guna2TextBox Subtotal { get; set; } // Quantity * Default Price
        Guna2TextBox Discount { get; set; }
        Guna2TextBox TotalProductPrice { get; set; }
        Guna2TextBox TotalWithVat { get; set; }
        CheckBox IsVatIncluded { get; set; }
        Label VatValue { get; set; }
        Label DiscountValue { get; set; }
        Guna2Button SaveQuantityt { get; set; }

    }
}
