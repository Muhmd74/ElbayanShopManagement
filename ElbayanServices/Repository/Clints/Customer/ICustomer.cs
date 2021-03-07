using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Clints.Supplier.Dtos;

namespace ElbayanServices.Repository.Clints.Customer
{
    public interface ICustomer
    {
      bool CreateCustomer(ClintDto model);
       bool UpdateCustomer(ClintDto model);
        List<ClintDto> GetAllCustomer();
        List<ClintDto> GetAllCustomerNotActive();
        ClintDto GetCustomerById( Guid id);
        bool ChangeActivity(Guid id);


    }
}
