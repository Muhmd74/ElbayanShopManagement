using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Product.ProductCategory;
using ElbayanDatabase.DataClasses.Product.Unit;

namespace ElbayanDatabase.DataClasses.Product
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string UCP { get; set; }
        public string BarCode { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal DefaultPrice { get; set; }
        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public long ProductNumber { get; set; }
        public bool IsExpired { get; set; } = false;
        public Guid LargeUnitId { get; set; }
        public LargeUnit LargeUnit { get; set; }
        public SmallUnit SmallUnit { get; set; }
        public Guid SmallUnitId { get; set; }

        public int LimitedDemand { get; set; }



    }
}
