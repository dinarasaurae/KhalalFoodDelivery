namespace KhalalFoodDelivery.Application.Models.Entities;
public class ItemMenu
{
    public int Id { get; set; } // PK

    public string Name { get; set; } = null!;

    public float Price { get; set; }

    public string Description { get; set; } = null!;

    public IReadOnlyList<Cart> Carts { get; } = null!;

    public Guid MenuId { get; set; }

    public Menu? Menu { get; set; }
}
