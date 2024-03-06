namespace KhalalFoodDelivery.Application.Models.Entities;

public class Restaurant
{
    public Guid Id { get; set; }

    public string RestaurntAddress { get; set; }

    public string Name { get; set; }

    public List<Menu> Menus { get; set; } = new List<Menu>();

    public List<Order> Orders { get; set; } = new List<Order>();
}
