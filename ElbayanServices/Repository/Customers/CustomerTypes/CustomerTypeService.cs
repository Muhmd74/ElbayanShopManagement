using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Customers;
using ElbayanServices.Repository.Customers.CustomerTypes.Dtos;

namespace ElbayanServices.Repository.Customers.CustomerTypes
{
   public class CustomerTypeService : ICustomerType , IDisposable
   {
       private readonly ConnectionOption _context;

       public CustomerTypeService(ConnectionOption context)
       {
           _context = context;
       }

       public bool Create(CustomerTypeDto model)
       {
           var type = _context.CustomerTypes.Add(new CustomerType()
           {
               Name = model.Name
           });
           _context.SaveChanges();
           return true;
       }

        public bool Update(CustomerTypeDto model)
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

        public List<CustomerTypeDto> GetAll()
        {
            return _context.CustomerTypes.Select(d => new CustomerTypeDto()
            {
                Id = d.Id,
                Name = d.Name
            }).ToList();
        }

        public CustomerTypeDto GetById(Guid id)
        {
            var type = _context.CustomerTypes.FirstOrDefault(d => d.Id == id);

            if (type!=null)
            {
                return new CustomerTypeDto
                {
                    Id=type.Id,
                    Name=type.Name
                };
            }

            return null ;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
