using ElbayaNPresentation.Presenters.Orders;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Purchases.ProcurementOrder
{
    public interface IViewProcurementOrder :IViewOrder
    {
        PresenterProcurementOrder Presenter { get; set; }
    }
}
