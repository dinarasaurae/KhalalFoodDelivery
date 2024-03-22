namespace KhalalFoodDelivery.Application.Models.Entities;

public class CartItem
{
    public Guid Id { get; private set; }

    public Guid CartId { get; set; }

    public Cart? Cart { get; set; }

    public Guid MenuItemId { get; set; }

    public ItemMenu? ItemMenu { get; set; }

    public int Quantity { get; set; }
}