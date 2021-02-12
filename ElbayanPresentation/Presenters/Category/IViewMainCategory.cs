using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanPresentation.Presenters.Category

{
    public interface IViewMainCategory
    {
        string CategoryName { get; set; }
        string CategoryDescription { get; set; }
        MainCategoryPresenter Presenter { set; }

    }
}
