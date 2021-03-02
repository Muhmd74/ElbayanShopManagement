using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Product;
using ElbayanServices.Repository.Products.Product.Dtos;
using ElbayanServices.Repository.Products.SubCategory;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using ElbayanServices.Repository.Products.Units.LargeUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductCard
{
    public class ProductPresnter
    {
        private readonly IViewProdcut _view;

        private readonly ProductService productServices = new ProductService(new ConnectionOption());
        
        public ProductPresnter(IViewProdcut view)
        {
            _view = view;
        }

        public List<SubCategoryNameDto> FillcbxSubcategory()
        {
            return     _view.SubCategories = productServices.GetAllSubCategory().ToList();                     
        }
        public List<LargeUnitNameDto> FillcbxLargeUnit()
        {
            return _view.LargeUnits = productServices.GetAllLargeUnit().ToList();
        }
        public List<SmallUnitNameDto> FillcbxSmallunit(Guid ID)
        {
            
            return _view.smallUnits = productServices.GetAllSmallUnitByLargeUnit(ID).ToList();
        } 

        // Generate Rndom number 

        public long GenerateProductNumber()
        {
           return  productServices.GeneratorRandomNumber();
        }
        public void OnCLickbtnAdd()
        {
            productServices.Add(new ProductDto
            {
                Name = _view.ProudctName.Text,
                Description = _view.Description.Text,
                BarCode = _view.BarCode,
                SubCategoryId = _view.SubCategoryId,
                LargeUnitId = new Guid(_view.LargeUnit.SelectedValue.ToString()),
                SmallUnitId = _view.SmallUnitId,
                IsUnitSale = _view.IsUnitSale,
                LimitedDemand = Convert.ToInt32(_view.LimitedDemand.Text),
                IsExpired = _view.IsExpired,
                ImageUrl = _view.ImageUrl,
                UCP =_view.UCP,
                PurchaseDefaultPrice = _view.PurchaseDefaultPrice,
                SaleDefaultPrice = _view.SaleDefaultPrice,
                WholesalePrice = _view.WholesalePrice.Value,
                //IsMAinSalesUnit = _view.IsMainSaleUnit,
                Vat = _view.VAT,
                Discount =_view.Disccount
            });
        }
    }
}
