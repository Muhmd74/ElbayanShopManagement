using DevExpress.XtraEditors;
using ElbayaNPresentation.Presenters.Store.Product.ProductCard;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Store.Product
{
    public partial class ucNewProductCard : DevExpress.XtraEditors.XtraUserControl, IViewProdct
    {
        public ucNewProductCard()
        {
            InitializeComponent();
            Presenter = new ProductPresnter(this);
        }

        // Apply singlton pattern for form Instance
        private static ucNewProductCard _instance;
        public static ucNewProductCard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucNewProductCard();
                return _instance;
            }
        }

        public int UCP { get => Convert.ToInt32(txtUCPNumber.Text); set => Convert.ToInt32(txtUCPNumber.Text); }
        public int BarCode { get => Convert.ToInt32(txtCBCNumber.Text); set => Convert.ToInt32(txtCBCNumber.Text); }
        public string ImageUrl { get; set; }
        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public decimal PurchaseDefaultPrice { get => nudDefaultPurchasePrice.Value; set => nudDefaultPurchasePrice.Value = value; }
        public decimal SaleDefaultPrice { get => nudDefaultSalePrice.Value; set => nudDefaultSalePrice.Value = value; }
        public decimal WholesalePrice { get => nudDefaultWholesalePrice.Value; set => nudDefaultWholesalePrice.Value = value; }
        public bool IsUnitSale { get; set; }
        public Guid SubCategoryId { get; set; }
        public SubCategoryDto SubCategory { get; set; }
        public long ProductNumber { get; set; }
        public bool IsExpired { get; set; }
        public DateTime ExpireDateTime { get; set; }
        public Guid LargeUnitId { get; set; }
        public LargeUnitDto LargeUnit { get; set; }
        public List<LargeUnitDto> LargeUnits { get; set; }
        public Guid SmallUnitId { get; set; }
        public SmallUnitDto SmallUnit { get; set; }
        public List<SmallUnitDto> smallUnits { get; set; }
        public int LimitedDemand { get; set; }
        public ProductPresnter Presenter { private get; set; }
    }
}
