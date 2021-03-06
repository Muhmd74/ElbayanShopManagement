using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Clints;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanDatabase.DataClasses.Product.ProductCategory;
using ElbayanDatabase.DataClasses.Product.Unit;

namespace ElbayanDatabase.DataClasses.Product
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public long UCP { get; set; }
        public long BarCode { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateTime { get; set; }
        public int TotalQuantity { get; set; }
        public string Description { get; set; }
        public decimal PurchaseDefaultPrice { get; set; }
        public decimal SaleDefaultPrice { get; set; }
        public decimal WholesalePrice{ get; set; }
        public bool IsUnitSale { get; set; }//true ? LargeSale : SmallSale
        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int ProductNumber { get; set; }
        public bool IsExpired { get; set; } = false;
        public Guid LargeUnitId { get; set; }
        public LargeUnit LargeUnit { get; set; }
        public SmallUnit SmallUnit { get; set; }
        public Guid SmallUnitId { get; set; }
        public bool IsDeleted { get; set; }
        public int LimitedDemand { get; set; }
        public decimal Vat { get; set; }
        public decimal Discount { get; set; }
        public ICollection<ProductStock> ProductStocks { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }


    }
}
