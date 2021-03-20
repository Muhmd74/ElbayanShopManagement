using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Employees.Employees;
using ElbayanDatabase.DataClasses.Product;

namespace ElbayanDatabase.DataClasses.Clints.Sales
{
   public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public Guid ClintId { get; set; }
        public Clint Clint { get; set; }
        public decimal SubTotalWithoutDiscount { get; set; }// sum all  TotalPrice
        public decimal TotalDiscount { get; set; } 
        public decimal TotalAfterDiscount { get; set; } // SubTotalWithoutDiscount - TotalDiscount
        public decimal Payment { get; set; }
        public bool IsDeferred { get; set; }
        public bool IsReturn { get; set; }
        public string OrderType { get; set; }
        public long OrderNumber { get; set; }
        public decimal Deferred { get; set; } //المتبقي
        public Guid PosId { get; set; }
        public POS Pos { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<DeferredPayment> DeferredPayments { get; set; }
        public ICollection<OrderProduct> OrderProduct { get; set; }
        public ICollection<ProductStock> ProductStock { get; set; }


    }
}
