using KhalalFoodDelivery.Application.Contracts.ServiceInterfaces.DTO;

namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;
internal interface IRestaurantService
{
    Task<IEnumerable<RestaurantDto>> GetAllRestaurants();

    Task<DeliveryTimeResponse> GetDeliveryTime(string? address);

    Task<RestaurantDetailsDto> GetRestaurantDetails(Guid restaurantId);

    Task<ItemMenuDto> AddItemToCart(Guid userPk, Guid itemPk, uint quantity, OptionsDto options);
}
