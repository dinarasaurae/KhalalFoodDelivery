namespace KhalalFoodDelivery.Application.Models.Entities;

public class Customer
{
    public Customer(string name, string surname, string email, string password, IReadOnlyList<Order> orders, IReadOnlyList<Cart> carts)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Email = email;
        Password = password;
        Orders = orders;
        Carts = carts;
    }

    protected Customer(string name, string surname, string email, string password)
    {
        throw new NotImplementedException();
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public IReadOnlyList<Order> Orders { get; set; }

    public IReadOnlyList<Cart> Carts { get; set; }

    public IReadOnlyList<Token> Tokens { get; set; } = new List<Token>();
}
