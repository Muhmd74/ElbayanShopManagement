using ElbayanServices.Repository.Products.SubCategory.Dtos;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Product.ProductCard
{
    public interface IViewProdcut
    {
        int UCP { get; set; }
        int BarCode { get; set; }
        Guna2TextBox ProudctName { get; set; }
        string ImageUrl { get; set; }
        Guna2TextBox Description { get; set; }
        decimal PurchaseDefaultPrice { get; set; }
        decimal SaleDefaultPrice { get; set; }
        NumericUpDown WholesalePrice { get; set; }
        bool IsUnitSale { get; set; } //true ? LargeSale : SmallSale

        //string IsMainSaleUnit { get; set; } // Cbx Text for sale unit name.
        Guid SubCategoryId { get; set; }
        SubCategoryNameDto SubCategory { get; set; }
        List<SubCategoryNameDto> SubCategories { get; set; }
        bool IsExpired { get; set; }
        DateTime ExpireDateTime { get; set; }

        Guid LargeUnitId { get; set; }
        Guna2ComboBox LargeUnit { get; set; }
        List<LargeUnitNameDto> LargeUnits { get; set; }
        Guid SmallUnitId { get; set; }
        SmallUnitNameDto SmallUnit { get; set; }
        List<SmallUnitNameDto> smallUnits { get; set; }
        Guna2TextBox LimitedDemand { get; set; }
        int Disccount { get; set; }
        int VAT { get; set; }

        Guna2TextBox ProductQuantity { get; set; }
        ProductPresnter Presenter { set; }

    }
}
