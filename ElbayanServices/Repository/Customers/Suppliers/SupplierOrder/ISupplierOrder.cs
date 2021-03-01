using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Customers.Suppliers.SupplierOrder.Dtos;

namespace ElbayanServices.Repository.Customers.Suppliers.SupplierOrder
{
    public interface ISupplierOrder
    {
        bool CreateSupplierOrder(SupplierOrderDto model);
    }
}
