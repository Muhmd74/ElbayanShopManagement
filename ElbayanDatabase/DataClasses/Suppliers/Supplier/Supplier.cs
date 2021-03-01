using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Customers;
using ElbayanDatabase.DataClasses.Customers.Sales;

namespace ElbayanDatabase.DataClasses.Suppliers.Supplier
{
   public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int IdNumber { get; set; }
        public string FirmName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string CommercialRegister { get; set; }
        public string TaxNumber { get; set; }
        public bool IsActive { get; set; }
        public int OpeningBalance { get; set; }
        public int SupplierNumber { get; set; }
        public Guid CustomerTypeId { get; set; }
        public CustomerType CustomerType { get; set; }
        public ICollection<SupplierOrder.SupplierOrder> SupplierOrders { get; set; }
    }
}
