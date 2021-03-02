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
        Guid ProductId { get; set; }
        Guna2TextBox UCP { get; set; }
        Guna2TextBox BarCode { get; set; }
        Guna2TextBox ProudctName { get; set; }
        Guna2TextBox PSNumber { get; set; }
        string ImageUrl { get; set; }
        Guna2TextBox Description { get; set; }
        NumericUpDown PurchaseDefaultPrice { get; set; }
        NumericUpDown SaleDefaultPrice { get; set; }
        NumericUpDown WholesalePrice { get; set; }
        bool IsUnitSale { get; set; } //true ? LargeSale : SmallSale
        //string IsMainSaleUnit { get; set; } // Cbx Text for sale unit name.
        Guna2ComboBox SubCategory { get; set; }
        bool IsExpired { get; set; }
        Guna2ComboBox LargeUnit { get; set; }
        Guna2ComboBox SmallUnit { get; set; }
        Guna2TextBox LimitedDemand { get; set; }
        NumericUpDown Disccount { get; set; }
        NumericUpDown VAT { get; set; }
        Guna2TextBox ProductQuantity { get; set; }
        ProductPresnter Presenter { set; }

    }
}
