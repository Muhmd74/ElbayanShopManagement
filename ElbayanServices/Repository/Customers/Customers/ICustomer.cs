using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Customers.Customers.Dtos;

namespace ElbayanServices.Repository.Customers.Customers
{
    public interface ICustomer
    {
        bool Create(CustomerDto model);
        bool Update(CustomerDto model);
        List<CustomerDto> GetAllCustomer();
        List<CustomerDto> GetAllCustomerNotActive();
        CustomerDto GetById( Guid id);
        bool ChangeActivity(Guid id);
        List<CustomerDto> GetCustomerByType(Guid typeId);
        CustomerDetailsDto GetCustomerDetails(Guid customerId);


    }
}
