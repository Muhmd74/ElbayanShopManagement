using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Building.POS
{
    public class POSPresenter
    {
        private readonly IViewPOS _view;

        public POSPresenter(IViewPOS view)
        {
            _view = view;
        }

    }
}
