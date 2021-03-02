using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Building
{
    public interface IViewBuilding
    {
        Guna2TextBox BuildingName { get; set; }
        Guna2TextBox BuildingDescription { get; set; }
        Guna2TextBox BuildingAddress { get; set; }
        Guna2TextBox BuildingAddressPhoneNumber { get; set; }
        Guna2TextBox SearchtxtBox { get; set; }
        DataGridView dgvActiveObjects { get; set; }
        DataGridView dgvDeletedObjects { get; set; }
        BuildingPresenter Presenter { get; set; }

    }
}
