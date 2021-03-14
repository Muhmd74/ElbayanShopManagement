using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Finance.Employee.ALLEmployee
{
    public interface IViewAllEmployee
    {
        Guid ID { get; set; }
        Guna2TextBox SearchTextBox { get; set; }
        Guna2Button AddObject { get; set; }
        DataGridView ActiveObject { get; set; }
        DataGridView NotActiveObject { get; set; }
        TabControl TabContainer { get; set; }
        PresenterAllEmployee Presenter { get; set; }
    }
}
