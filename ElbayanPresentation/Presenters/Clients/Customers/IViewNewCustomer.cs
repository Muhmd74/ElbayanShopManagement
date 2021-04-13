using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Clients.Customers
{
    public interface IViewNewCustomer : IViewNewClient
    {
        PresenterNewCutsomer Presenter { get; set; }
    }
}
