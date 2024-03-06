namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;
internal interface ICartService
{
    Task<CartResponse> AddItemToCartAsync(AddItemRequest request);

    Task<CartResponse> UpdateCartAsync(UpdateCartRequest request);

    Task<>
}