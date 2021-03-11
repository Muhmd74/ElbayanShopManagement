using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Unit.LargeUnit
{
    public interface IViewLargeUnit
    {
        Guid ID { get; set; }
        Guna2TextBox LargeUnitName { get; set; }
        Guna2TextBox LargeUnitDescirption { get; set; }
        Guna2TextBox SearchTextBox { get; set; }
        DataGridView ActiveObject { get; set; }
        DataGridView DeletedObject { get; set; }
        Guna2Button UpdateObject { get; set; }
        Guna2Button DeleteObject { get; set; }
        Guna2Button AddObject { get; set; }
        TabControl DGVTabControl { get; set; }
        LargeUnitPresenter Presenter { get;  set; }
    }
}
