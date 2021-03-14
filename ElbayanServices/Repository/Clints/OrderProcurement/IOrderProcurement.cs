using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Clints.Orders.Dtos;

namespace ElbayanServices.Repository.Clints.OrderProcurement
{
   public interface IOrderProcurement
    {
        bool CreateOrderProcurement(OrderDto model);


    }
}
