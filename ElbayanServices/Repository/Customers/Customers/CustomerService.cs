using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Customers;
using ElbayanDatabase.DataClasses.Customers.Sales;
using ElbayanServices.Repository.Customers.Customers.Dtos;

namespace ElbayanServices.Repository.Customers.Customers
{
   public class CustomerService : ICustomer , IDisposable
   {
       private readonly ConnectionOption _context;

       public CustomerService(ConnectionOption context)
       {
           _context = context;
       }

       public bool Create(CustomerDto model)
       {
           var customer = _context.Customers.Add(new Customer()
           {
               Name = model.Name,
               IdNumber = model.IdNumber,
               IsActive = true,
               ActivityName = model.ActivityName,
               Address = model.Address,
               CommercialRegister = model.CommercialRegister,
               CustomerNumber = model.CustomerNumber,
               Description = model.Description,
               CustomerTypeId = model.CustomerTypeId,
               Mobile = model.Mobile,
               TaxNumber = model.TaxNumber,
               OpeningBalance = model.OpeningBalance
           });
           _context.SaveChanges();
           return true;
       }

        public bool Update(CustomerDto model)
        {
            var customer = _context.Customers.FirstOrDefault(d => d.Id == model.Id);

            if (customer!=null)
            {
                customer.Description = model.Description;
                customer.ActivityName = model.ActivityName;
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

        public List<CustomerDto> GetAllCustomer()
        {
            return _context.Customers
                .Where(d=>d.IsActive)
                .Select(d => new CustomerDto()
            {
                Description = d.Description,
                ActivityName = d.ActivityName,
                Address = d.Address,
                CommercialRegister = d.CommercialRegister,
                CustomerNumber = d.CustomerNumber,
                CustomerTypeId = d.CustomerTypeId,
                Id = d.Id,
                 IdNumber = d.IdNumber,
                 Mobile = d.Mobile,
                 Name = d.Name,
                 OpeningBalance = d.OpeningBalance,
                 TaxNumber = d.TaxNumber
            }).ToList();
        }
        public List<CustomerDto> GetAllCustomerNotActive()
        {
            return _context.Customers
                .Where(d => d.IsActive==false)
                .Select(d => new CustomerDto()
                {
                    Description = d.Description,
                    ActivityName = d.ActivityName,
                    Address = d.Address,
                    CommercialRegister = d.CommercialRegister,
                    CustomerNumber = d.CustomerNumber,
                    CustomerTypeId = d.CustomerTypeId,
                    Id = d.Id,
                    IdNumber = d.IdNumber,
                    Mobile = d.Mobile,
                    Name = d.Name,
                    OpeningBalance = d.OpeningBalance,
                    TaxNumber = d.TaxNumber
                }).ToList();
        }
        public CustomerDto GetById(Guid id)
        {
            var customer = _context.Customers.FirstOrDefault(d => d.Id == id);
            if (customer!=null)
            {
                return new CustomerDto()
                {
                    Description = customer.Description,
                    ActivityName = customer.ActivityName,
                    Address = customer.Address,
                    CommercialRegister = customer.CommercialRegister,
                    CustomerNumber = customer.CustomerNumber,
                    CustomerTypeId = customer.CustomerTypeId,
                    Id = customer.Id,
                    IdNumber = customer.IdNumber,
                    Mobile = customer.Mobile,
                    Name = customer.Name,
                    OpeningBalance = customer.OpeningBalance,
                    TaxNumber = customer.TaxNumber
                };
            }

            return null;

        }

        public bool ChangeActivity(Guid id)
        {
            var customer = _context.Customers.FirstOrDefault(d => d.Id == id);
            if (customer!=null)
            {
                customer.IsActive = !customer.IsActive;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<CustomerDto> GetCustomerByType(Guid typeId)
        {
            return _context.Customers
                .Where(d => d.CustomerTypeId==typeId&&d.IsActive)
                .Select(d => new CustomerDto()
                {
                    Description = d.Description,
                    ActivityName = d.ActivityName,
                    Address = d.Address,
                    CommercialRegister = d.CommercialRegister,
                    CustomerNumber = d.CustomerNumber,
                    CustomerTypeId = d.CustomerTypeId,
                    Id = d.Id,
                    IdNumber = d.IdNumber,
                    Mobile = d.Mobile,
                    Name = d.Name,
                    OpeningBalance = d.OpeningBalance,
                    TaxNumber = d.TaxNumber
                }).ToList();
        }

        public CustomerDetailsDto GetCustomerDetails(Guid customerId)
        {
            var customer = _context.Customers
                .Include(d=>d.CustomerType)
                .Include(d => d.Orders)
                .Include(d=>d.Orders.FirstOrDefault().DeferredPayments)
                .Include(d=>d.Orders.FirstOrDefault().Employee)
                .FirstOrDefault(d => d.Id == customerId);
            if (customer!=null)
            {
                return new CustomerDetailsDto()
                {
                    Description = customer.Description,
                    ActivityName = customer.ActivityName,
                    Address = customer.Address,
                    CommercialRegister = customer. CommercialRegister,
                    CustomerNumber = customer.CustomerNumber,
                    CustomerTypeName = customer.CustomerType.Name,
                    IdNumber = customer.IdNumber,
                    Name = customer.Name,
                    Mobile = customer.Mobile,
                    OpeningBalance = customer.OpeningBalance,
                    TaxNumber = customer.TaxNumber,
                    IsActive = customer.IsActive,
                    CustomerDetailsOrders = customer.Orders.Select(d=>new CustomerDetailsOrder()
                    {
                               DateTime = d.DateTime,
                               Deferred = d.Deferred,
                               EmployeeName = d.Employee.Name,
                               SubTotalWithoutDiscount = d.SubTotalWithoutDiscount,
                               TotalAfterDiscount = d.TotalAfterDiscount,
                               TotalDiscount = d.TotalDiscount,
                               Payment = d.Payment,
                               IsDeferred = d.IsDeferred,
                               DeferredPayments = d.DeferredPayments.Select(a=>new DeferredPayment()
                               {
                                   Balance = a.Balance,
                                   DeferredOfOrder = a.DeferredOfOrder,
                                   DueDatePayingOff = a.DueDatePayingOff,
                                   Payment = a.Payment,
                               }).ToList()
                    }).ToList()

                };
            }

            return null;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
