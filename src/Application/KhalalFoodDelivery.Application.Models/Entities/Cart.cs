namespace KhalalFoodDelivery.Application.Models.Entities;
public class Cart
{
    public Guid Id { get; set; }

    public string Status { get; set; } = null!;

    public IReadOnlyList<ItemMenu> ItemMenus { get; set; } = null!;

    public string CustomerId { get; set; } = null!; // FK

    public Customer Customer { get; set; } = null!;
}
