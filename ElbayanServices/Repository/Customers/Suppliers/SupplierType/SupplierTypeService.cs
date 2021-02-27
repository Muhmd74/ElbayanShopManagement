using System;
using System.Collections.Generic;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Customers;
using ElbayanServices.Repository.Customers.Suppliers.SupplierType.Dtos;

namespace ElbayanServices.Repository.Customers.Suppliers.SupplierType
{
   public class SupplierTypeService : ISupplierType, IDisposable
   {
       private readonly ConnectionOption _context;

       public SupplierTypeService(ConnectionOption context)
       {
           _context = context;
       }

       public bool Create(SupplierTypeDto model)
       {
           var type = _context.CustomerTypes.Add(new CustomerType()
           {
               Name = model.Name,
               IsSupplier = true
           });
           _context.SaveChanges();
           return true;
       }

        public bool Update(SupplierTypeDto model)
        {
            var type = _context.CustomerTypes.FirstOrDefault(d => d.Id == model.Id);
            if (type!=null)
            {
                type.Name = model.Name;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<SupplierTypeDto> GetAll()
        {
            return _context.CustomerTypes.Where(d=>d.IsSupplier).Select(d => new SupplierTypeDto()
            {
                Id = d.Id,
                Name = d.Name
            }).ToList();
        }

        public SupplierTypeDto GetById(Guid id)
        {
            var type = _context.CustomerTypes.FirstOrDefault(d => d.Id == id);

            if (type!=null)
            {
                return new SupplierTypeDto
                {
                    Id=type.Id,
                    Name=type.Name
                };
            }

            return null ;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
