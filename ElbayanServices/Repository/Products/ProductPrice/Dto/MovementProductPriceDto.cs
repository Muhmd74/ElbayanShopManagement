using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Products.ProductPrice.Dto
{
   public class MovementProductPriceDto
    {
        public DateTime DateTime { get; set; }
        public decimal PriceSale { get; set; }
        public string ProcessType { get; set; }
        public decimal Vat { get; set; }
        public decimal Discount { get; set; }
        public string ProductName { get; set; }
        public string UserName { get; set; }
        public string UnitName { get; set; }
        public long? OrderNumber { get; set; }
        public decimal ProductPrice { get; set; }
        public long? BarCode { get; set; }
        public long? ProductNumber { get; set; }
    }
}
