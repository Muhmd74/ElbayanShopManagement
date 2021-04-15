using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Suppliers.Supplier.Dtos;

namespace ElbayanServices.Repository.Suppliers.Supplier
{
    public interface ISupplier
    {
       // bool CreateSupplier(ClintDto model);
      //  bool UpdateSupplier(ClintDto model);
        List<ClintDto> GetAllSupplier();
        List<SupplierNameDto> GetSupplierName();
        List<ClintDto> GetAllSupplierNotActive();
        ClintDto GetSupplierById( Guid id);
        bool ChangeActivity(Guid id);


    }
}
