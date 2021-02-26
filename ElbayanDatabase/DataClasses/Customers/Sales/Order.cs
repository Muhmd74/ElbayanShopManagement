using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Customers.Sales
{
   public class Order
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal SubTotalWithoutDiscount { get; set; }// sum all  TotalPrice
        public decimal TotalDiscount { get; set; } 
        public decimal TotalAfterDiscount { get; set; } // SubTotalWithoutDiscount - TotalDiscount
        public decimal Payment { get; set; }
        public bool IsDeferred { get; set; }
        public decimal Deferred { get; set; } //المتبقي
        public Guid PosId { get; set; }
        public POS Pos { get; set; }
        //public Guid UserSignOrder { get; set; }
        public ICollection<DeferredPayment> DeferredPayments { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        
        

    }
}
