using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Clients
{
    public interface IViewSuppleir : IViewAllClient
    {
        PresenterNewClient Presenter { get; set; }
    }
}
