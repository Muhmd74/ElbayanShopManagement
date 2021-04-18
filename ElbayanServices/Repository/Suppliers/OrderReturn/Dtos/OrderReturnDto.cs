using System;
using System.Collections.Generic;

namespace ElbayanServices.Repository.Suppliers.OrderReturn.Dtos
{
    public class OrderReturnDto
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime DueDatePayingOff { get; set; }
        public Guid ClintId { get; set; }
        public decimal SubTotalWithoutDiscount { get; set; }// sum all  TotalPrice
        public decimal TotalDiscount { get; set; }
        public long OrderNumber { get; set; }
        public decimal TotalAfterDiscount { get; set; } // SubTotalWithoutDiscount - TotalDiscount
        public decimal Payment { get; set; }
        public bool IsDeferred { get; set; }
        public decimal PaymentPerMonth { get; set; } // القسط الشهري
        public decimal Deferred { get; set; } //المتبقي
        public Guid PosId { get; set; }
        public Guid EmployeeId { get; set; }

        //OrderProduct
        public List<OrderReturnProductDto> OrderReturnProduct { get; set; }

    }

    public class OrderReturnProductDto
    {
        public string ProductName { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal PriceSale { get; set; } // ProductDefaultSale Or New Price
        public decimal SubTotalPrice { get; set; } // Quantity * PriceSale 
        public decimal Discount { get; set; }
        public decimal TotalProductPrice { get; set; } // subtotal-Discount
        public decimal Vat { get; set; } // price * vat in Product /100 
        public decimal TotalPrice { get; set; } // TotalProductPrice + vat
        public Guid OrderId { get; set; }
    }
}