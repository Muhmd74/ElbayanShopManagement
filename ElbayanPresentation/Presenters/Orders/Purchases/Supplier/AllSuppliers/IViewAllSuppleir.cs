using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElbayaNPresentation.Presenters.Purchases.Supplier.AllSuppliers;

namespace ElbayaNPresentation.Presenters.Purchases.Supplier.AllSuppliers
{ 
    public interface IViewAllSuppleir
    {
        DataGridView ActiveObject { get; set; }
        DataGridView DeletedObject { get; set; }
        Guna2TextBox SearchtxtBox { get; set; }
        Guna2Button AddNewObject { get; set; }
        TabControl TabControl { get; set; }
        PresenterSupplierData Presenter { get; set; }
    }
}
