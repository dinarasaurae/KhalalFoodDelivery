namespace KhalalFoodDelivery.Application.Models.Entities;

public class Customer
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public List<Order> Orders { get; set; }

    public List<Cart> Carts { get; set; }
}
