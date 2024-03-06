namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;

public class LogoutRequest
{
    public Guid Pk { get; set; }

    public string Token { get; set; }
}