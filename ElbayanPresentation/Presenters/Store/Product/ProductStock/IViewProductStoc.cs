using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductStock
{
    public interface IViewProductStoc
    {
        PresenterProductStock Presenter { get; set; }
        Guna2TextBox ProductBarCode { get; set; }
        ComboBox ActiveProduct { get; set; }
        ComboBox ProcessType { get; set; }
        Guna2DateTimePicker StartDate { get; set; }
        Guna2DateTimePicker EndDate { get; set; }
        Guna2Button Search { get; set; }
        DataGridView SearchResult { get; set; }
    }
}
