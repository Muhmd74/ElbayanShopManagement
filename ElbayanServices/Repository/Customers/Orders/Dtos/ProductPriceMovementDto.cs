using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Customers.Orders.Dtos
{
  public  class ProductPriceMovementDto
    {
        public decimal ProductDefaultSale { get; set; }
        public decimal ProductVat { get; set; }
        public decimal ProductDiscount { get; set; }
       
    }
}
