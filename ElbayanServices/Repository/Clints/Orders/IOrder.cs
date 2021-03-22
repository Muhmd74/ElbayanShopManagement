using System;
using ElbayanServices.Repository.Clints.Orders.Dtos;

namespace ElbayanServices.Repository.Clints.Orders
{
    public interface IOrder
    {
        bool CreateCustomerOrder(OrderDto model);
        ProductPriceMovementDto GetProductPriceMovement(Guid productId);
        decimal GetLastProductPrice(Guid productId);

    }
}
