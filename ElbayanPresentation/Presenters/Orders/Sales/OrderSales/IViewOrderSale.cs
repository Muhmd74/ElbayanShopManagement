using ElbayaNPresentation.Presenters.Orders;

namespace ElbayaNPresentation.Presenters.Sales.OrderSales
{
    public interface IViewOrderSale : IViewOrder
    {
        PresenterOrderSales Presenter { get; set; }

    }
}
