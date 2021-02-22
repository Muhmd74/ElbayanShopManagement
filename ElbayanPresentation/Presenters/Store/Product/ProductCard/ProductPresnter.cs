using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductCard
{
    public class ProductPresnter
    {
        private readonly IViewProdct _view;

        private readonly ProductService productServices = new ProductService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public ProductPresnter(IViewProdct view)
        {
            _view = view;
        }

        public List<SubCategoryDto> GetAllSubCategory()
        {
            return _view.smallUnits = productServices.GetAllByCategory().ToList();
        }
    }
}
