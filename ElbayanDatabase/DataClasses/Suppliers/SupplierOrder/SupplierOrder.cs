using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Customers.Sales;
using ElbayanDatabase.DataClasses.Employees.Employees;

namespace ElbayanDatabase.DataClasses.Suppliers.SupplierOrder
{
   public class SupplierOrder
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier.Supplier Supplier { get; set; }
        public decimal SubTotalWithoutDiscount { get; set; }// sum all  TotalPrice
        public decimal TotalDiscount { get; set; }
        public decimal TotalAfterDiscount { get; set; } // SubTotalWithoutDiscount - TotalDiscount
        public decimal Payment { get; set; }
        public bool IsDeferred { get; set; }
        public long OrderNumber { get; set; }
        public decimal Deferred { get; set; } //المتبقي
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<SupplierDeferredPayment> SupplierDeferredPayments { get; set; }
        public ICollection<SupplierOrderProduct> SupplierOrderProducts { get; set; }
    }
}
