using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Clients
{
    public interface IViewAllClient
    {
        Guid ID { get; set; }
        Guna2TextBox SearchTextBox { get; set; }
        Guna2Button AddNewClient { get; set; }
        TabControl TabControl { get; set; }
        DataGridView ActiveObject { get; set; }
        DataGridView DeletedObject { get; set; }

    }
}
