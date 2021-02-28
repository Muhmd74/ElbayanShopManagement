using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Product;
using ElbayanDatabase.DataClasses.Suppliers.SupplierOrder;

namespace ElbayanServices.Repository.Customers.Suppliers.SupplierOrder.Dtos
{
  public  class SupplierOrderDto
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public Guid SupplierId { get; set; }
        public decimal SubTotalWithoutDiscount { get; set; }// sum all  TotalPrice
        public decimal TotalDiscount { get; set; }
        public decimal TotalAfterDiscount { get; set; } // SubTotalWithoutDiscount - TotalDiscount
        public decimal Payment { get; set; }
        public bool IsDeferred { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DueDatePayingOff { get; set; }

        public decimal Deferred { get; set; } //المتبقي
        public Guid EmployeeId { get; set; }
        public List<SupplierOrderProducts> SupplierOrderProducts { get; set; }
    }

  public class SupplierOrderProducts
  {
      public Guid Id { get; set; }
      public string Name { get; set; }
      public Guid ProductId { get; set; }
      public Guid SupplierOrderId { get; set; }
      public string ProductName { get; set; }
      public int Quantity { get; set; }
      public decimal PriceSale { get; set; } // ProductDefaultSale Or New Price
      public decimal SubTotalPrice { get; set; } // Quantity * PriceSale 
      public decimal Discount { get; set; }
      public decimal TotalProductPrice { get; set; } // subtotal-Discount
      public decimal Vat { get; set; } // price * vat in Product /100 
      public decimal TotalPrice { get; set; } // TotalProductPrice + vat

    }
}
