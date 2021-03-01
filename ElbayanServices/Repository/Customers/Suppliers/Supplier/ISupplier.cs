using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Customers.Suppliers.Supplier.Dtos;

namespace ElbayanServices.Repository.Customers.Suppliers.Supplier
{
    public interface ISupplier
    {
        bool Create(SupplierDto model);
        bool Update(SupplierDto model);
        List<SupplierNameDto> GetSuppliersName();
        List<SupplierDto> GetAllSupplierNotActive();
        List<SupplierDto> GetAllSupplier();
        SupplierDto GetById(Guid id);
        bool ChangeActivity(Guid id);
        List<SupplierDeferredDto> GetDeferredBytSupplier(Guid supplierId);

    }
}
