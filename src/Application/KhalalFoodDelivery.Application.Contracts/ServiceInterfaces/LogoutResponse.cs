using KhalalFoodDelivery.Application.Models.Entities;
using System.ComponentModel.Design;

namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;
public class LogoutResponse
{
    public string Token { get; set; }

    public string Message { get; set; }

    public Customer User { get; set; }

    public Menu menuu { get; set; }
}