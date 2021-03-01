using System;
using System.Collections.Generic;
using SupplierTypeDto = ElbayanServices.Repository.Customers.Suppliers.SupplierType.Dtos.SupplierTypeDto;

namespace ElbayanServices.Repository.Customers.Suppliers.SupplierType
{
    public interface ISupplierType
    {
        bool Create(SupplierTypeDto model);
        bool Update(SupplierTypeDto model);
        List<SupplierTypeDto> GetAll();
        SupplierTypeDto GetById(Guid id);
    }
}
