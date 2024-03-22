using KhalalFoodDelivery.Application.Contracts.ServiceInterfaces.DTO;
using KhalalFoodDelivery.Application.Models.Entities;

namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;
internal interface ICartService
{
    List<ItemMenuDto> GetCartItems(Guid userPk);

    void EmptyCart(Guid userPk);

    CartDto UpdateCart(Guid userPk, List<ItemMenu> itemList);
}
