namespace KhalalFoodDelivery.Application.Models.Entities;
public class ItemMenu
{
    public int Id { get; set; } // PK

    public string Name { get; set; }

    public float Price { get; set; }

    public string Description { get; set; }

    public List<Cart> Carts { get; }

    public string TagMenuTag { get; set; } // FK

    public TagMenu TagMenu { get; set; }
}
