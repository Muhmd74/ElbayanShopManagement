using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Product.Unit;

namespace ElbayanServices.Repository.Products.Product.Dtos
{
   public class ProductDto
    {
        public Guid Id { get; set; }
        public int UCP { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMAinSalesUnit { get; set; }
        public int BarCode { get; set; }
         public string Name { get; set; }
        public string Description { get; set; }
        public Guid SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public long ProductNumber { get; set; }
        public bool IsExpired { get; set; } = false;
        public Guid LargeUnitId { get; set; }
        public string LargeUnitName { get; set; }
        public string SmallUnitName { get; set; }
        public Guid SmallUnitId { get; set; }
        public decimal PurchaseDefaultPrice { get; set; }
        public decimal SaleDefaultPrice { get; set; }
        public decimal WholesalePrice { get; set; }
        public int LimitedDemand { get; set; }
    }
}
