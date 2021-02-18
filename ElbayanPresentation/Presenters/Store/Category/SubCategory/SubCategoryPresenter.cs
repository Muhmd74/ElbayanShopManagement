using ElbayanServices.Repository.Products.Category;
using ElbayanServices.Repository.Products.SubCategory;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using ElbayanDatabase.ConnectionTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Products.Category.Dtos;

namespace ElbayaNPresentation.Presenters.Store.Category.SubCategory
{
    public class SubCategoryPresenter
    {
        private static IViewSubCategory _view;
        
        private static CategoryService MainCategory = new CategoryService(new ConnectionOption());

        private static SubCategoryService subCategory = new SubCategoryService(new ConnectionOption());

        public SubCategoryPresenter(IViewSubCategory view)
        {
            _view = view;
        }

        public List<CategoryDto> FillcbxMainCategory()
        {
             _view.MainCategory = MainCategory.GetAll();
            return _view.MainCategory.ToList();
        }

        public void OnClickbtnAdd()
        {
            subCategory.Add(new SubCategoryDto {
                CategoryId = new Guid (_view.CategoryId),
                Name = _view.SubCategoryName,
                Description = _view.SubCategoryDescription 
            });
        }
        public List<SubCategoryDto> GetAllSubCategory()
        {
            _view.subCategories =  subCategory.GetAll();
            return _view.subCategories.ToList();
        }
        public void OnClickbtnUpdate(Guid ID, Guid MainCateogrID)
        {
            subCategory.Update(new SubCategoryDto {
                CategoryId = /*new Guid (_view.CategoryId)*/ MainCateogrID,
                Name = _view.SubCategoryName,
                Description = _view.SubCategoryDescription, 
                Id = ID,
                //CategoryName = _view.DgvMainCategoryName
            });
        }

    }
}
