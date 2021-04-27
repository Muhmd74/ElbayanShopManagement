using System;
using ElbayanServices.Repository.Clints.Orders.Dtos;

namespace ElbayanServices.Repository.Clints.Orders
{
    public interface IOrder
    {
        Guid CreateCustomerOrder(OrderCustomerDto model);
        ProductPriceMovementDto GetProductPriceMovement(Guid productId);
        decimal GetLastProductPrice(Guid productId);

    }
}
