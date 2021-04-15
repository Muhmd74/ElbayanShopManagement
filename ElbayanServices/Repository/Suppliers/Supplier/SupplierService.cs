using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Suppliers.Supplier.Dtos;

namespace ElbayanServices.Repository.Suppliers.Supplier
{
    public class SupplierService : ISupplier, IDisposable
    {
        private readonly ConnectionOption _context;

        public SupplierService(ConnectionOption context)
        {
            _context = context;
        }

        // public bool CreateSupplier(ClintDto model)
        //{
        //    var customer = _context.Clints.Add(new Clint()
        //    {
        //        Name = model.Name,
        //        NationalIdentity = model.NationalIdentity,
        //        IsActive = true,
        //        FirmName = model.FirmName,
        //        Address = model.Address,
        //        CommercialRegister = model.CommercialRegister,
        //        ReferenceNumber = model.ReferenceNumber,
        //        Description = model.Description,
        //        Mobile = model.Mobile,
        //        TaxNumber = model.TaxNumber,
        //        OpeningBalance = model.OpeningBalance,
        //        FaxNumber = model.FaxNumber,
        //        IsSupplier = true,
        //        Phone = model.Phone,

        //    });
        //    _context.SaveChanges();
        //    return true;
        //}

        //public bool UpdateSupplier(ClintDto model)
        //{
        //    var clint = _context.Clints.FirstOrDefault(d => d.Id == model.Id);

        //    if (clint!=null)
        //    {
        //        clint.Description = model.Description;
        //        clint.FirmName = model.FirmName;
        //        clint.Address = model.Address;
        //        clint.CommercialRegister = model.CommercialRegister;
        //        clint.NationalIdentity = model.NationalIdentity;
        //        clint.Mobile = model.Mobile;
        //        clint.OpeningBalance = model.OpeningBalance;
        //        clint.TaxNumber = model.TaxNumber;
        //        clint.Name = model.Name;
        //        clint.ReferenceNumber = model.ReferenceNumber;
        //        clint.Phone = model.Phone;
        //        _context.SaveChanges();
        //        return true;

        //    }

        //    return false;
        //}

        public List<ClintDto> GetAllSupplier()
        {
            return _context.Clints
                .Where(d => d.IsSupplier
                          && d.IsActive)
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

        public List<SupplierNameDto> GetSupplierName()
        {
            return _context.Clints.Where(d => d.IsSupplier
                                              && d.IsActive)
                .Select(d => new SupplierNameDto()
                {
                    Id = d.Id,
                    Name = d.Name
                }).ToList();
        }

        public List<ClintDto> GetAllSupplierNotActive()
        {
            return _context.Clints
                .Where(d => d.IsSupplier
                           && d.IsActive == false)
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
        public ClintDto GetSupplierById(Guid id)
        {
            var customer = _context.Clints.FirstOrDefault(d => d.IsSupplier && d.Id == id);
            if (customer != null)
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
                    FaxNumber = customer.FaxNumber,
                    IsActive = customer.IsActive
                };
            }

            return null;

        }

        public bool ChangeActivity(Guid id)
        {
            var clint = _context.Clints.FirstOrDefault(d => d.Id == id);
            if (clint != null)
            {
                clint.IsActive = !clint.IsActive;
                _context.SaveChanges();
                return true;
            }

            return false;
        }



        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
