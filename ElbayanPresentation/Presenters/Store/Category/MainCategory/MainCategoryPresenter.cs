using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Category.MainCategory
{
    public class MainCategoryPresenter
    {
        private readonly IViewMainCategory _view;

        public MainCategoryPresenter(IViewMainCategory view)
        {
            _view = view;
        }

    }
}
