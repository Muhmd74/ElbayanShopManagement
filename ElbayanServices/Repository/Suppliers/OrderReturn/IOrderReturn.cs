using System;
using ElbayanServices.Repository.Suppliers.OrderReturn.Dtos;

namespace ElbayanServices.Repository.Suppliers.OrderReturn
{
    public interface IOrderReturn
    {
        Guid CreateSupplierOrderReturn(OrderReturnDto model);
    }
}
