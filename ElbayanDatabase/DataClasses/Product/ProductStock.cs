using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Clints.Sales;

namespace ElbayanDatabase.DataClasses.Product
{
  public  class ProductStock
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public string StockStatues { get; set; }
        public int Stock { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }


}
