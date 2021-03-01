using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Customers.Orders.Dtos;

namespace ElbayanServices.Repository.Customers.Orders
{
    public interface IOrder
    {
        bool Create(OrderDto model);
        ProductPriceMovementDto GetProductPriceMovement(Guid productId);
    }
}
