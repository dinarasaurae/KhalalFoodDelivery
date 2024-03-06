namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;

public class TokenRequest
{
    public string Token { get; set; }

    public string Message { get; set; }

    public Customer Customer { get; set; }
}
