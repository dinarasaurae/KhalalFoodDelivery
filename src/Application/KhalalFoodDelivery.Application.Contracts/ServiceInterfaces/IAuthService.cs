using KhalalFoodDelivery.Application.Contracts.ServiceInterfaces.DTO;
using KhalalFoodDelivery.Application.Models.Entities;

namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;

internal interface IAuthService
{
    CustomerDto Register(string name, string surname, string email, string password);

    CustomerDto Login(string name, string surname, string email, string password);

    Token RefreshToken(Guid pk, Token refreshToken);

    void Logout(Guid pk, Token token);
}
