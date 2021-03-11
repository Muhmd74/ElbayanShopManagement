using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Unit.SmallUnit
{
    public interface IViewSmallUnit
    {
        Guid ID { get; set; }
        Guna2TextBox SmallUnitName { get; set; }
        Guna2TextBox Description { get; set; }
        NumericUpDown Weight { get; set; }
        Guna2TextBox SearchKeyword { get; set; }
        Guna2ComboBox LargeUnit { get; set; }
        DataGridView ActiveObject { get; set; }
        DataGridView DeletedObject { get; set; }
        Guna2Button UpdateObject { get; set; }
        Guna2Button DeleteObject { get; set; }
        Guna2Button AddObject { get; set; }
        TabControl DGVTabControl { get; set; }
        SmallUnitPresenter Presenter { get;  set; }
    }

}
