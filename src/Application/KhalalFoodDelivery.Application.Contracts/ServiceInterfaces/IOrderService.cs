namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;
internal interface IOrderService
{
    Task<OrderResponse> PlaceOrderAsync(OrderRequest request);
}
