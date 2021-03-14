using ElbayanServices.Repository.Clints.Orders.Dtos;

namespace ElbayanServices.Repository.Clints.OrderReturns
{
   public interface IOrderReturn
    {
        bool CreateOrderReturn(OrderDto model);

    }
}
