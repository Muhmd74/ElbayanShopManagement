using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Suppliers.OrderReturn.Dtos;

namespace ElbayanServices.Repository.Suppliers.OrderReturn
{
   public interface IOrderReturn
    {
        Guid CreateSupplierOrderReturn(OrderReturnDto model);
    }
}
