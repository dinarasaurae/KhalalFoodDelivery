namespace KhalalFoodDelivery.Application.Models.Entities;

public class Cart
{
    public Guid Id { get; set; }

    public string Status { get; set; }

    public List<ItemMenu> ItemMenus { get; set; }

    public string CustomerId { get; set; } // FK

    public Customer Customer { get; set; }
}
