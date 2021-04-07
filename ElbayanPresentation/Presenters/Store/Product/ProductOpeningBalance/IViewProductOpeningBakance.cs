using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductOpeningBalance
{
    public interface IViewProductOpeningBakance
    {
        ComboBox ActiveProduct { get; set; }
        Label AvailableQuantity { get; set; }
        Guna2TextBox ProductStock { get; set; }
        Guna2Button AddObject { get; set; }
        PresenterProductOpeneingBalance Presenter { get; set; }
    }
}
