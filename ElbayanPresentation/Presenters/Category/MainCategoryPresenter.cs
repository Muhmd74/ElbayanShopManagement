using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Category;
using ElbayanServices.Repository.Products.Category.Dtos;

namespace ElbayanPresentation.Presenters.Category
{
    public class MainCategoryPresenter
    {
        private readonly IViewMainCategory _view;
        private readonly CategoryService CategoryService = new CategoryService(new ConnectionOption());

        public MainCategoryPresenter(IViewMainCategory view)
        {
            _view = view;
        }

        public void click()
        {
            CategoryService.Add(new CategoryDto()
            {
                Description = _view.CategoryDescription,
                Name = _view.CategoryName
            });
        }


    }
}
