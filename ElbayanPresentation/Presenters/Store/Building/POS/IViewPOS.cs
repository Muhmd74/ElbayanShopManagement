using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Building.POS
{
    public interface IViewPOS
    {
        Guid POSsId { get; set; }
        Guna2TextBox POSsgName { get; set; }
        Guna2TextBox POSsShortCode { get; set; }
        Guna2ComboBox Buidling { get; set; }
        Guna2TextBox SearchtxtBox { get; set; }
        DataGridView dgvActiveObjects { get; set; }
        DataGridView dgvDeletedObjects { get; set; }
        Guna2Button btnAddObject { get; set; }
        Guna2Button btnUpdateObject { get; set; }
        Guna2Button btnDeleteObject { get; set; }
        TabControl dgvContainer { get; set; }
        POSPresenter Presenter { get; set; }
    }
}