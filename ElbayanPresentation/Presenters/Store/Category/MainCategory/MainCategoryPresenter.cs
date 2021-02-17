using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Category;
using ElbayanServices.Repository.Products.Category.Dtos;
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
        CategoryService Category = new CategoryService(new ConnectionOption());

        public MainCategoryPresenter(IViewMainCategory view)
        {
            _view = view;
        }


        public void OnClickAddButtonFuction()
        {
            Category.Add( new CategoryDto { 
                Name = _view.MainCategoryName, 
                Description = _view.MainCategoryDescription
            });
        }
        public List<CategoryDto> GetCategories()
        {
            _view.MainCategory = Category.GetAll();
            return _view.MainCategory.ToList();
        }
        public void OnCLickbtnUpdate(Guid ID)
        {
            Category.Update(new CategoryDto
            {
                Id = ID,
                Name = _view.MainCategoryName,
                Description = _view.MainCategoryDescription
            });
        }

    }
}
