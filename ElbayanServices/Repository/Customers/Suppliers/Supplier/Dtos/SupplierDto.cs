using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Customers;

namespace ElbayanServices.Repository.Customers.Suppliers.Supplier.Dtos
{
   public class SupplierDto
    {
        public Guid Id { get; set; }
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
    }
}
