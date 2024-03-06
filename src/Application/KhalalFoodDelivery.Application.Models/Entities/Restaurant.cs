namespace KhalalFoodDelivery.Application.Models.Entities;

public class Restaurant
{
    public Guid Id { get; set; }

    public string RestaurntAddress { get; set; } = null!;

    public string Name { get; set; } = null!;

    public IReadOnlyList<Menu> Menus { get; set; } = new List<Menu>();

    public IReadOnlyList<Order> Orders { get; set; } = new List<Order>();
}
