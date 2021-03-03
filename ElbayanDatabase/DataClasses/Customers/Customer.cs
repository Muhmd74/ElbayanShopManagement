using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElbayanDatabase.DataClasses.Customers.Sales;

namespace ElbayanDatabase.DataClasses.Customers
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int IdNumber { get; set; }
        public string ActivityName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string CommercialRegister { get; set; }
        public string TaxNumber { get; set; }
        public bool IsActive { get; set; }
        public int OpeningBalance { get; set; }
        public int CustomerNumber { get; set; }
        public Guid CustomerTypeId { get; set; }
        public CustomerType CustomerType { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}
