namespace KhalalFoodDelivery.Application.Models.Entities;

public class Order
{
    public Guid Id { get; set; }

    public Customer Customer { get; set; }

    public Restaurant Restaurant { get; set; }

    public List<ItemMenu> Items { get; set; }

    public DateTime OrderTime { get; set; }
}
