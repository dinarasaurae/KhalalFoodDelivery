namespace KhalalFoodDelivery.Application.Models.Entities;
public class Cart
{
    public Guid Id { get; set; }

    public string? Status { get; set; }

    public IReadOnlyList<ItemMenu>? ItemMenus { get; set; }

    public string? CustomerId { get; set; }

    public Customer? Customer { get; set; }
}
