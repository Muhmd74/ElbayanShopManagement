using ElbayanServices.Repository.Products.Category.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Category.MainCategory
{
    public interface IViewMainCategory
    {
        string MainCategoryName { get; set; }

        string MainCategoryDescription { get; set; }

        List<CategoryDto> MainCategory { get; set; }

        MainCategoryPresenter Presenter { set; }
    }
}
