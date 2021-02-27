using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Customers;
using ElbayanDatabase.DataClasses.Customers.Sales;
using ElbayanDatabase.DataClasses.Employees.Employees;

namespace ElbayanServices.Repository.Customers.Customers.Dtos
{
   public class CustomerDetailsOrder
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal SubTotalWithoutDiscount { get; set; }// sum all  TotalPrice
        public decimal TotalDiscount { get; set; }
        public decimal TotalAfterDiscount { get; set; } // SubTotalWithoutDiscount - TotalDiscount
        public decimal Payment { get; set; }
        public bool IsDeferred { get; set; }
        public decimal Deferred { get; set; } //المتبقي
        public Guid PosId { get; set; }
        public POS Pos { get; set; }
        public string EmployeeName { get; set; }
        //public Guid UserSignOrder { get; set; }
        public List<DeferredPayment> DeferredPayments { get; set; }
     }
}
