using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Clients.Suppliers
{
    public interface IViewNewSupplier : IViewNewClient
    {
        PresenterNewSupplier Presenter { get; set; }
    }
}
