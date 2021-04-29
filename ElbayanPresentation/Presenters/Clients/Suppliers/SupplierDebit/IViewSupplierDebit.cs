using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ElbayaNPresentation.Presenters.Clients.Suppliers.SupplierDebit
{
    public interface IViewSupplierDebit
    {
        PresenterSupplierDebit Presenter { get; set; }
        ComboBox SupplierList { get; set; }
        Guna2DateTimePicker StartDateToFilterBy { get; set; }
        Guna2DateTimePicker EndDateToFilterBy { get; set; }
        Guna2Button Searchbtn { get; set; }
        Guna2Button Printbtn { get; set; }
        DataGridView SuppliersMovementList { get; set; }
    }
}
