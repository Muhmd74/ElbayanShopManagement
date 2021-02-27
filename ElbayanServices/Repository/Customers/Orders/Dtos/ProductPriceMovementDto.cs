using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Customers.Orders.Dtos
{
  public  class ProductPriceMovementDto
    {
        public decimal productDefaultSale { get; set; }
        public decimal productVat { get; set; }
        public decimal productDiscount { get; set; }
       
    }
}
