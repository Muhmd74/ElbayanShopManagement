using ElbayanServices.Repository.Products.Product.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Product.AllProduct
{
    public interface IViewAllProduct
    {
        string SearchKeyword { get; set; }
        List<ProductDto> products { get; set; }

        AllProductPresenter Presenter { set; }
    }
}
