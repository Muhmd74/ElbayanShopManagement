using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Clints.Sales;

namespace ElbayanDatabase.DataClasses.Clints
{
    public class Clint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Required]
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public int NationalIdentity { get; set; }
        public string FirmName { get; set; }
        public string FaxNumber { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string CommercialRegister { get; set; }
        public string TaxNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsSupplier { get; set; }
        public bool IsCustomer { get; set; }
        public int OpeningBalance { get; set; }
        public int ReferenceNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<DeferredPayment> DeferredPayments { get; set; }

    }
}
