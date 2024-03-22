namespace KhalalFoodDelivery.Application.Models.Entities;

public class CorporateUser : Customer
{
    public string? CompanyName { get; set; }

    public CorporateUser(string name, string surname, string email, string password) : base(name, surname, email, password)
    {
    }
}
