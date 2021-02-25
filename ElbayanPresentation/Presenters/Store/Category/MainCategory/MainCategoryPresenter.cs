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
            if (Category.GetAll().Any())
            {
                _view.MainCategory = Category.GetAll();
                return _view.MainCategory.ToList();
            }
            else
            {
                return _view.MainCategory = null;
            }
        }
        public List<CategoryDto> GetDeletedCategories()
        {
            _view.MainCategory = Category.GetAllDeleted();
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
        public void OnClickDelete(Guid ID)
        {
            Category.DeleteOrRestore(ID);
        }

        public List<CategoryDto> FilterDataGridView()
        {
            _view.MainCategory = Category.GetAll().Where(x => x.Name.Contains(_view.SearchKeyword) || x.Description.Contains(_view.SearchKeyword)).ToList();
            return _view.MainCategory.ToList();
        }
        public List<CategoryDto> FilterDataGridViewDeleted()
        {
            _view.MainCategory = Category.GetAllDeleted().Where(x => x.Name.Contains(_view.SearchKeyword) || x.Description.Contains(_view.SearchKeyword)).ToList();
            return _view.MainCategory.ToList();
        }
    }
}
