namespace KhalalFoodDelivery.Application.Models.Entities;

internal class Restaurant
{
    public Restaurant()
    {
        
    }
    public Guid Id { get; set; }

    public string RestaurntAddress { get; set; }

    public string Name { get; set; }
}
