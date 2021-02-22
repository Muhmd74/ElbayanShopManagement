using ElbayanServices.Repository.Products.SubCategory.Dtos;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductCard
{
    public interface IViewProdct
    {
        int UCP { get; set; }
        int BarCode { get; set; }
        string Name { get; set; }
        string ImageUrl { get; set; }
        string Description { get; set; }
        decimal PurchaseDefaultPrice { get; set; }
        decimal SaleDefaultPrice { get; set; }
        decimal WholesalePrice { get; set; }
        bool IsUnitSale { get; set; }//true ? LargeSale : SmallSale
        Guid SubCategoryId { get; set; }
        SubCategoryDto SubCategory { get; set; }
        long ProductNumber { get; set; }

        bool IsExpired { get; set; }
        DateTime ExpireDateTime { get; set; }

        Guid LargeUnitId { get; set; }
        LargeUnitDto LargeUnit { get; set; }
        List<LargeUnitDto> LargeUnits { get; set; }
        Guid SmallUnitId { get; set; }
        SmallUnitDto SmallUnit { get; set; }
        List<SmallUnitDto> smallUnits { get; set; }
        int LimitedDemand { get; set; }

        ProductPresnter Presenter { set; }

    }
}
