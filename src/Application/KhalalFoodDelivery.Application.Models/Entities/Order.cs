using KhalalFoodDelivery.Application.Models.Interfaces;

namespace KhalalFoodDelivery.Application.Models.Entities;

internal class Order
{
    public Order()
    {
        Id = Guid.NewGuid();
        Customer = customer ?? throw new ArgumentNullException(nameof(Customer));
        Restaurant = restaurant ?? throw new ArgumentNullException(nameof(Restaurant));
        DeliveryCostStrategy = deliveryCostStrategy ?? throw new ArgumentNullException(nameof(IDeliveryCostStrategy));
        Items = new List<OrderItem>();
        OrderTime = DateTime.UtcNow;
    }

    public Guid Id { get; set; }

    public Customer Customer { get; set; }

    public Restaurant Restaurant { get; set; }

    public List<OrderItem> Items { get; set; }

    public DateTime OrderTime { get; set; }

    public IDeliveryCostStrategy DeliveryCostStrategy { get; set; }

    public decimal TotalPrice => Items.Sum(item => item.Item.Price * item.Quantity);

    public decimal CalculateDeliveryCost() => DeliveryCostStrategy.CalculateDeliveryCost(this);
}
