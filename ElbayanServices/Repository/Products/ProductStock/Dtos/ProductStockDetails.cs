using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Products.ProductStock.Dtos
{
   public class ProductStockDetails
    {
        public string ProductName { get; set; }
        public string UserName { get; set; }
        public string UnitName { get; set; }
        public string OrderType { get; set; }
        public long OrderNumber { get; set; }
        public DateTime DateTime { get; set; }
        public int Quantity { get; set; }
        public long BarCode { get; set; }
        public int ProductNumber { get; set; }
    }
}
