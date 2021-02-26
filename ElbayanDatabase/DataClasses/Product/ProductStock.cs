using System;

namespace ElbayanDatabase.DataClasses.Product
{
  public  class ProductStock
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public string StockStatues { get; set; }
        public int Stock { get; set; }
     }


}
