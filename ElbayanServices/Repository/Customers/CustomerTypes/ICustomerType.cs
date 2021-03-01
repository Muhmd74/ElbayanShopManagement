using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Customers.CustomerTypes.Dtos;
using ElbayanServices.Repository.Customers.Suppliers.SupplierType.Dtos;

namespace ElbayanServices.Repository.Customers.CustomerTypes
{
    public interface ICustomerType
    {
        bool Create(CustomerTypeDto model);
        bool Update(CustomerTypeDto model);
        List<CustomerTypeDto> GetAll();
        CustomerTypeDto GetById(Guid id);
    }
}
