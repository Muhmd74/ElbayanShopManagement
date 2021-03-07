using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElbayanDatabase.DataClasses.Clints.Sales
{
   public class OrderProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ProductId { get; set; }
        public Product.Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal PriceSale { get; set; } // ProductDefaultSale Or New Price
        public decimal SubTotalPrice { get; set; } // Quantity * PriceSale 
        public decimal Discount { get; set; }
        public decimal TotalProductPrice { get; set; } // subtotal-Discount
        public decimal Vat { get; set; } // price * vat in Product /100 
        public decimal TotalPrice { get; set; } // TotalProductPrice + vat
        public Guid OrderId { get; set; }
        public Order Order { get; set; }


    }
}
