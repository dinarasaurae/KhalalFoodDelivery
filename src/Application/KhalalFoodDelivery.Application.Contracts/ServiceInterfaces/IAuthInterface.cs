namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;

internal interface IAuthInterface
{
    Task<TokenResponse> RegisterAsync(RegisterRequest request);
    Task<TokenResponse> LoginAsync(LoginRequest request);
    Task<LogoutResponse> LogoutAsync(LogoutRequest request);
}
