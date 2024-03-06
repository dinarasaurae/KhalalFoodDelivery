namespace KhalalFoodDelivery.Application.Models.Entities;

public class Menu
{
    public Menu(Restaurant restaurant)
    {
        Id = Guid.NewGuid();
        Restaurant = restaurant ?? throw new ArgumentNullException(nameof(restaurant));
        RestaurantAddress = restaurant.RestaurntAddress;
        TagMenus = new List<TagMenu>();
    }

    public Guid Id { get; private set; }

    public IReadOnlyList<TagMenu> TagMenus { get; set; }

    public string RestaurantAddress { get; private set; } // FK

    public Restaurant Restaurant { get; set; }
}
