using System;
using System.Collections.Generic;

namespace ElbayanServices.Repository.Clints.OrderProcurement.Dtos
{
  public class OrderDto
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime DueDatePayingOff { get; set; }
        public Guid ClintId { get; set; }
        public decimal SubTotalWithoutDiscount { get; set; }// sum all  TotalPrice
        public decimal TotalDiscount { get; set; }
        public decimal TotalAfterDiscount { get; set; } // SubTotalWithoutDiscount - TotalDiscount
        public decimal Payment { get; set; }
        public bool IsDeferred { get; set; }
        public decimal PaymentPerMonth { get; set; } // القسط الشهري
        public decimal Deferred { get; set; } //المتبقي
        public Guid PosId { get; set; }
        public Guid EmployeeId { get; set; }

        //OrderProduct
        public List<OrderProductDto> OrderProductDto { get; set; }

    }

  public class OrderProductDto
  {
      public string ProductName { get; set; }
      public Guid ProductId { get; set; }
      public int Quantity { get; set; }
      public decimal PriceSale { get; set; } // ProductDefaultSale Or New Price
      public decimal SubTotalPrice { get; set; } // Quantity * PriceSale 
      public decimal Discount { get; set; }
      public decimal TotalProductPrice { get; set; } // subtotal-Discount
      public int Vat { get; set; } // price * vat in Product /100 
      public decimal TotalPrice { get; set; } // TotalProductPrice + vat
      public Guid OrderId { get; set; }
    }
}
