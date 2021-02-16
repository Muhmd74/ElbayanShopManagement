using ElbayanDatabase.ConnectionTools;
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
        private readonly ConnectionOption _context;

        public MainCategoryPresenter(IViewMainCategory view)
        {
            _view = view;
        }

        public void OnClickAddButtonFuction()
        {
           
        }
    }
}
