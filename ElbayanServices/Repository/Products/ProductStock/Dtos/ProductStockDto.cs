using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Products.ProductStock.Dtos
{
    public class ProductStockDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string StockStatues { get; set; }
        public int Stock { get; set; }
        public int ProductQuantity { get; set; }
    }
}
