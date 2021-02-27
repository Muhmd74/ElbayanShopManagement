using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Customers.Suppliers.Supplier.Dtos;

namespace ElbayanServices.Repository.Customers.Suppliers.Supplier
{
    public class SupplierService : ISupplier, IDisposable
    {
        private readonly ConnectionOption _context;

        public SupplierService(ConnectionOption context)
        {
            _context = context;
        }

        public bool Create(SupplierDto model)
        {
            var customer = _context.Suppliers.Add(new ElbayanDatabase.DataClasses.Suppliers.Supplier.Supplier()
            {
                Name = model.Name,
                IdNumber = model.IdNumber,
                IsActive = true,
                FirmName = model.FirmName,
                Address = model.Address,
                CommercialRegister = model.CommercialRegister,
                SupplierNumber = model.SupplierNumber,
                Description = model.Description,
                CustomerTypeId = model.CustomerTypeId,
                Mobile = model.Mobile,
                TaxNumber = model.TaxNumber,
                OpeningBalance = model.OpeningBalance
            });
            _context.SaveChanges();
            return true;
        }

        public bool Update(SupplierDto model)
        {
            var customer = _context.Suppliers.FirstOrDefault(d => d.Id == model.Id);

            if (customer != null)
            {
                customer.Description = model.Description;
                customer.FirmName = model.FirmName;
                customer.Address = model.Address;
                customer.CommercialRegister = model.CommercialRegister;
                customer.CustomerTypeId = model.CustomerTypeId;
                customer.IdNumber = model.IdNumber;
                customer.Mobile = model.Mobile;
                customer.OpeningBalance = model.OpeningBalance;
                customer.TaxNumber = model.TaxNumber;
                customer.Name = model.Name;
                _context.SaveChanges();
                return true;

            }

            return false;
        }

        public List<SupplierNameDto> GetSuppliersName()
        {
            return _context.Suppliers.Where(d => d.IsActive)
                .Select(d => new SupplierNameDto()
                {
                    Id = d.Id,
                    Name = d.Name
                }).ToList();

        }

        public List<SupplierDto> GetAllSupplierNotActive()
        {
            return _context.Suppliers.Where(d => d.IsActive == false)
                .Select(d => new SupplierDto()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Description = d.Description,
                    Address = d.Address,
                    CommercialRegister = d.CommercialRegister,
                    CustomerTypeId = d.CustomerTypeId,
                    FirmName = d.FirmName,
                    IdNumber = d.IdNumber,
                    OpeningBalance = d.OpeningBalance,
                    SupplierNumber = d.SupplierNumber,
                    TaxNumber = d.TaxNumber,
                    Mobile = d.Mobile
                }).ToList();
        }

        public List<SupplierDto> GetAllSupplier()
        {
            return _context.Suppliers.Where(d => d.IsActive)
                .Select(d => new SupplierDto()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Description = d.Description,
                    Address = d.Address,
                    CommercialRegister = d.CommercialRegister,
                    CustomerTypeId = d.CustomerTypeId,
                    FirmName = d.FirmName,
                    IdNumber = d.IdNumber,
                    OpeningBalance = d.OpeningBalance,
                    SupplierNumber = d.SupplierNumber,
                    TaxNumber = d.TaxNumber,
                    Mobile = d.Mobile
                }).ToList();
        }

        public SupplierDto GetById(Guid id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(d => d.Id == id);
            return new SupplierDto()
            {
                Id = supplier.Id,
                Name = supplier.Name,
                Description = supplier.Description,
                Address = supplier.Address,
                CommercialRegister = supplier.CommercialRegister,
                CustomerTypeId = supplier.CustomerTypeId,
                FirmName = supplier.FirmName,
                IdNumber = supplier.IdNumber,
                OpeningBalance = supplier.OpeningBalance,
                SupplierNumber = supplier.SupplierNumber,
                TaxNumber = supplier.TaxNumber,
                Mobile = supplier.Mobile
            };
        }

        public bool ChangeActivity(Guid id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(d => d.Id == id);
            if (supplier != null)
            {
                supplier.IsActive = !supplier.IsActive;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<SupplierDeferredDto> GetDeferredBytSupplier(Guid supplierId)
        {
            return _context.SupplierDeferredPayments.Include(d=>d.SupplierOrder)
                .Include(d=>d.SupplierOrder.Supplier)
                .Where(d => d.SupplierOrder.SupplierId == supplierId )
                .Select(d=>new SupplierDeferredDto()
                {
                    SupplierOrderNumber = d.SupplierOrder.OrderNumber,
                    Balance = d.Balance,
                    CollectingPaymentDate = d.CollectingPaymentDate,
                    DeferredOfOrder = d.DeferredOfOrder,
                    DueDatePayingOff = d.DueDatePayingOff.ToUniversalTime(),
                    Id = d.Id,
                    Payment = d.Payment,
                    TotalPayment = d.TotalPayment,
                    SupplierOrderId = d.SupplierOrderId,
                    SupplierName = d.SupplierOrder.Supplier.Name
                })
                .ToList();
           
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
