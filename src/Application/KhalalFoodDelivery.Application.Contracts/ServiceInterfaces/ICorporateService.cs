using KhalalFoodDelivery.Application.Contracts.ServiceInterfaces.DTO;

namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;

internal interface ICorporateService
{
    CoprorateAccountCreationRequestModelDto CreateCorporateAccount(Guid customerPk, CreateCorporateAccountDto dto);

    CorporateAccountCreationRequestListModelDto GetCorporateRequests(Guid customerPk);

    CorporateUserModel ActivateCorporateAccount(Guid userPk, Guid requestPk);

    void DeactivateCorporateAccount(Guid userPk, Guid corporatePk);

    RestaurantModelDto CreateRestaurant(RestaurantModelDto restaurantModelDto);
}