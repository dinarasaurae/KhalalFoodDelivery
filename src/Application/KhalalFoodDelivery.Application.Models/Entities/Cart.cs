namespace KhalalFoodDelivery.Application.Models.Entities;

internal class Cart
{
    public Guid Id { get; set; }

    public string Status { get; set; }

    public List<ItemMenu> ItemMenus { get; set; } = new List<ItemMenu>();

    public string CustomerId { get; set; } // FK

    public Customer Customer { get; set; }
}
