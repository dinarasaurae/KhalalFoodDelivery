namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;
internal interface IRestaurantService
{
    Task<IEnumerable<RestaurantDto>> GetAllRestaurantsAsync();
    Task<DeliveryTimeResponse> GetDeliveryTimeAsync(DeliveryTimeRequest request);
    Task<RestaurantDetailsDto> GetRestaurantDetailsAsync(Guid restaurantId);
}
