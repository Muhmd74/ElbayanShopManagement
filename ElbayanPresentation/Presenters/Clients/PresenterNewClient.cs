using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Clients
{
    public class PresenterNewClient
    {
        private readonly IViewNewClient _view;

        public PresenterNewClient(IViewNewClient view)
        {
            _view = view;
        }
    }
}
