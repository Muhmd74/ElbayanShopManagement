using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Clints.Customer.Dtos;
using ClintDto = ElbayanServices.Repository.Clints.Supplier.Dtos.ClintDto;

namespace ElbayanServices.Repository.Clints.Customer
{
    public interface ICustomer
    {
        bool CreateCustomer(ClintDto model);
        bool UpdateCustomer(ClintDto model);
        List<ClintDto> GetAllCustomer();
        List<CustomerNameDto> GetCustomerName();
        List<ClintDto> GetAllCustomerNotActive();
        ClintDto GetCustomerById(Guid id);
        bool ChangeActivity(Guid id);
        long GenerateClientNumber();
    }
}
