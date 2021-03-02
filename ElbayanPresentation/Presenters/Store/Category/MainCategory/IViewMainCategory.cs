using ElbayanServices.Repository.Products.Category.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Category.MainCategory
{
    public interface IViewMainCategory
    {
        Guna2TextBox MainCategoryName { get; set; }

        Guna2TextBox MainCategoryDescription { get; set; }
        string SearchKeyword { get; set; }

        List<CategoryDto> MainCategory { get; set; }

        MainCategoryPresenter Presenter { set; }
    }
}
