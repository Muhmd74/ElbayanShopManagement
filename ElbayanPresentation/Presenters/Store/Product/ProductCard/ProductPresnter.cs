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
        private readonly IViewProdct _view;

        private readonly ProductService productServices = new ProductService(new ConnectionOption());
        private readonly SubCategoryService subCategoryService = new SubCategoryService(new ConnectionOption());
        private readonly LargeUnitService largeUnitService = new LargeUnitService(new ConnectionOption());
        private readonly SmallService smallUnitService = new SmallService(new ConnectionOption());

        public ProductPresnter(IViewProdct view)
        {
            _view = view;
        }

        public List<SubCategoryDto> FillcbxSubcategory()
        {
            return     _view.SubCategories = subCategoryService.GetAll().ToList();                     
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
                Name = _view.ProudctName,
                Description = _view.Description,
                BarCode = _view.BarCode,
                SubCategoryId = _view.SubCategoryId,
                LargeUnitId = _view.LargeUnitId,
                SmallUnitId = _view.SmallUnitId,
                IsUnitSale = _view.IsUnitSale,
                LimitedDemand = _view.LimitedDemand,
                IsExpired = _view.IsExpired,
                ImageUrl = _view.ImageUrl,
                UCP =_view.UCP,
                PurchaseDefaultPrice = _view.PurchaseDefaultPrice,
                SaleDefaultPrice = _view.SaleDefaultPrice,
                WholesalePrice = _view.WholesalePrice,
                //IsMAinSalesUnit = _view.IsMainSaleUnit,
                Vat = _view.VAT,
                Discount =_view.Disccount
            });
        }
    }
}
