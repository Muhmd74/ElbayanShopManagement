﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Product.ProductCategory;
using ElbayanDatabase.DataClasses.Product.Unit;

namespace ElbayanDatabase.DataClasses.Product
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int UCP { get; set; }
        public int BarCode { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime DateTime { get; set; }
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
        public bool IsDeleted { get; set; }
        public int LimitedDemand { get; set; }
        public ICollection<ProductStock> ProductStocks { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }


    }
}