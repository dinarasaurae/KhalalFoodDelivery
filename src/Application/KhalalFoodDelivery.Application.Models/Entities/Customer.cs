namespace KhalalFoodDelivery.Application.Models.Entities;

internal class Customer
{
    public Customer(string name, string surname, string email, string password)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Email = email;
        Password = password;
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public List<Order> Orders { get; set; } = new List<Order>();

    public List<Cart> Carts { get; set; } = new List<Cart>();

    public List<Token> Tokens { get; set; } = new List<Token>();
}
