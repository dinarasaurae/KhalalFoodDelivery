namespace KhalalFoodDelivery.Application.Models.Entities;
public class TagMenu
{
    public string Tag { get; set; } = null!; // PK

    public IReadOnlyList<ItemMenu> ItemMenus { get; set; } = null!;
}