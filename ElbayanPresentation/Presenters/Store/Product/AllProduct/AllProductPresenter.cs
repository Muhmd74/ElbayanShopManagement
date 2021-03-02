using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.Product.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Product.AllProduct
{
    public class AllProductPresenter
    {
        private readonly IViewAllProduct _view;
        private readonly ProductService productSerice = new ProductService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public AllProductPresenter(IViewAllProduct view)
        {
            _view = view;
        }

        public List<ProductDto> PopulatedgvAllproduct()
        {
            return _view.products = productSerice.GetAll().ToList();
        }
        public List<ProductDto> FilterDataGridView()
        {
            return _view.products = productSerice.GetAll().Where(
                d => d.Name.Contains(_view.SearchKeyword) 
                || d.UCP.ToString().Contains(_view.SearchKeyword)
                || d.BarCode.ToString().Contains(_view.SearchKeyword)
                || d.ProductNumber.ToString().Contains(_view.SearchKeyword)
            ).ToList();
        }
        public List<ProductDto> PopulatedgvDeletedAllproduct()
        {
            return _view.products = productSerice.GetAllProductDeleted().ToList();
        }
    }
}
