using KhalalFoodDelivery.Application.Models.Entities;

namespace KhalalFoodDelivery.Application.Models.Entities;
public class Order
{
    public Guid Id { get; set; }

    public Customer Customer { get; set; } = null!;

    public Restaurant Restaurant { get; set; } = null!;

    public IReadOnlyList<OrderItem> Items { get; set; } = null!;

    public DateTime OrderTime { get; set; }
}
