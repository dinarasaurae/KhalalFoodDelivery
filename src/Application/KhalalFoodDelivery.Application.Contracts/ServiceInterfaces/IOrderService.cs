namespace KhalalFoodDelivery.Application.Contracts.ServiceInterfaces;
internal interface IOrderService
{
    void MakeOrder(Guid pk, string address, string? phoneNumber, string? someMoneyForm);
}
