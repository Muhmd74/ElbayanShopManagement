using System;

namespace ElbayanServices.Repository.Suppliers.Supplier.Dtos
{
  public  class ClintDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int NationalIdentity { get; set; }
        public string FirmName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string CommercialRegister { get; set; }
        public string TaxNumber { get; set; }
        public bool IsActive { get; set; }
        public int OpeningBalance { get; set; }
        public string FaxNumber { get; set; }
        public string Phone { get; set; }
        public int ReferenceNumber { get; set; }
        public bool IsSupplier { get; set; }
        public bool IsCustomer { get; set; }
    }
}
