using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Product
{
   public class ProductPrice
    {

        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime DateTime { get; set; }
        public decimal ProcPrice { get; set; }
        public string ProcessType { get; set; }
        public decimal Vat { get; set; }
        public decimal Sale { get; set; }
        public decimal Discount { get; set; }
        public bool IsBounce { get; set; }

    }
}
