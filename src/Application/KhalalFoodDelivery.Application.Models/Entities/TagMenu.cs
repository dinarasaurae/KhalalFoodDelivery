namespace KhalalFoodDelivery.Application.Models.Entities;
public class TagMenu
{
    public string Tag { get; set; } // PK

    public List<ItemMenu> ItemMenus { get; set; }
}