using ElbayanServices.Repository.Products.Category.Dtos;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Category.SubCategory
{
    public interface IViewSubCategory
    {
        string SubCategoryName { get; set; }
        string SubCategoryDescription { get; set; }

        string CategoryId { get; set; }
        List<CategoryDto> MainCategory { get; set; }
        List<SubCategoryDto> subCategories { get; set; }
        SubCategoryPresenter presenter { set; }
    }
}
