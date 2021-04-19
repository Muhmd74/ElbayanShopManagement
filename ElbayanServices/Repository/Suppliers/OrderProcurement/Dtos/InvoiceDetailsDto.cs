using System;
using System.Collections.Generic;

namespace ElbayanServices.Repository.Suppliers.OrderProcurement.Dtos
{
   public class InvoiceDetailsDto
    {
        public string MessageInvoice { get; set; }
        public string FirmName { get; set; }
        public int? Mobile { get; set; }
        public string LogoInvoice { get; set; }
        public string OrderType { get; set; }
        public long OrderNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string ClintName { get; set; }
        public string EmployeeName { get; set; }
        public string PosName { get; set; }
        public int ProductCount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalAfterDiscount { get; set; }
        public decimal? TotalVat { get; set; }
        public decimal? Payment { get; set; }
        public decimal? DeferredPrice { get; set; }
        public string OrderCode { get; set; }
        public List<ProductDto> Products { get; set; }
        public int? Phone { get; set; }
    }

   public class ProductDto
   {
       public string ProductName { get; set; }
       public string UnitName { get; set; }
       public int? Quantity { get; set; }
       public decimal? Price { get; set; }
       public decimal? TotalProductPrice { get; set; }
   }
}
