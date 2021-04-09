using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Clints;
using ElbayanServices.Repository.Clints.Customer.Dtos;
using ClintDto = ElbayanServices.Repository.Clints.Supplier.Dtos.ClintDto;

namespace ElbayanServices.Repository.Clints.Customer
{
   public class CustomerService : ICustomer , IDisposable
   {
       private readonly ConnectionOption _context;

       public CustomerService(ConnectionOption context)
       {
           _context = context;
       }

        public bool CreateCustomer(ClintDto model)
        {
            var customer = _context.Clints.Add(new Clint()
            {
                Name = model.Name,
                NationalIdentity = model.NationalIdentity,
                IsActive = model.IsActive,
                FirmName = model.FirmName,
                Address = model.Address,
                CommercialRegister = model.CommercialRegister,
                ReferenceNumber = model.ReferenceNumber,
                Description = model.Description,
                Mobile = model.Mobile,
                TaxNumber = model.TaxNumber,
                OpeningBalance = model.OpeningBalance,
                FaxNumber = model.FaxNumber,
                IsSupplier = model.IsSupplier,
                IsCustomer = model.IsCustomer,
                Phone = model.Phone,

            });
            _context.SaveChanges();
            return true;
        }

        public bool UpdateCustomer(ClintDto model)
        {
            var clint = _context.Clints.FirstOrDefault(d => d.Id == model.Id);

            if (clint != null)
            {
                clint.Description = model.Description;
                clint.FirmName = model.FirmName;
                clint.Address = model.Address;
                clint.CommercialRegister = model.CommercialRegister;
                clint.NationalIdentity = model.NationalIdentity;
                clint.Mobile = model.Mobile;
                clint.OpeningBalance = model.OpeningBalance;
                clint.TaxNumber = model.TaxNumber;
                clint.Name = model.Name;
                clint.ReferenceNumber = model.ReferenceNumber;
                clint.Phone = model.Phone;
                clint.IsCustomer = model.IsCustomer;
                clint.IsSupplier = model.IsSupplier;
                _context.SaveChanges();
                return true;

            }

            return false;
        }

        public List<ClintDto> GetAllCustomer()
        {
            return _context.Clints
                .Where(d=>d.IsCustomer
                            &&d.IsActive)
                .Select(d => new ClintDto()
            {
                Description = d.Description,
                FirmName = d.FirmName,
                Address = d.Address,
                CommercialRegister = d.CommercialRegister,
                Id = d.Id,
                 NationalIdentity = d.NationalIdentity,
                 Mobile = d.Mobile,
                 Name = d.Name,
                 OpeningBalance = d.OpeningBalance,
                 TaxNumber = d.TaxNumber,
                 Phone = d.Phone,
                 ReferenceNumber = d.ReferenceNumber,
                 FaxNumber = d.FaxNumber
            }).ToList();
        }

        public List<CustomerNameDto> GetCustomerName()
        {
            return _context.Clints.Where(d => d.IsCustomer
                                              && d.IsActive
            ).Select(d => new CustomerNameDto()
            {
                Id = d.Id,
                Name = d.Name
            }).ToList();
        }

        public List<ClintDto> GetAllCustomerNotActive()
        {
            return _context.Clints
                .Where(d =>d.IsCustomer
                           && d.IsActive==false)
                .Select(d => new ClintDto()
                {
                    Description = d.Description,
                    FirmName = d.FirmName,
                    Address = d.Address,
                    CommercialRegister = d.CommercialRegister,
                    ReferenceNumber = d.ReferenceNumber,
                    Id = d.Id,
                    NationalIdentity = d.NationalIdentity,
                    Mobile = d.Mobile,
                    Name = d.Name,
                    OpeningBalance = d.OpeningBalance,
                    TaxNumber = d.TaxNumber,
                    Phone = d.Phone,
                    FaxNumber = d.FaxNumber
                }).ToList();
        }
        public ClintDto GetCustomerById(Guid id)
        {
            var customer = _context.Clints.FirstOrDefault(d => d.IsSupplier==false && d.Id == id);
            if (customer!=null)
            {
                return new ClintDto()
                {
                    Description = customer.Description,
                    FirmName = customer.FirmName,
                    Address = customer.Address,
                    CommercialRegister = customer.CommercialRegister,
                    ReferenceNumber = customer.ReferenceNumber,
                    Id = customer.Id,
                    NationalIdentity = customer.NationalIdentity,
                    Mobile = customer.Mobile,
                    Name = customer.Name,
                    OpeningBalance = customer.OpeningBalance,
                    TaxNumber = customer.TaxNumber,
                    Phone = customer.Phone,
                    FaxNumber = customer.FaxNumber
                };
            }

            return null;

        }

        public bool ChangeActivity(Guid id)
        {
            var clint = _context.Clints.FirstOrDefault(d => d.Id == id);
            if (clint!=null)
            {
                clint.IsActive = !clint.IsActive;
                _context.SaveChanges();
                return true;
            }

            return false;
        }
        public long GenerateClientNumber()
        {
            var lastNumber = _context.Clints.AsEnumerable().Select(d => d.ReferenceNumber).LastOrDefault(); // Error Not active can not count ?
            if (lastNumber >= 0)
            {
                return (long)(lastNumber + 1);
            }

            return 201001;
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
