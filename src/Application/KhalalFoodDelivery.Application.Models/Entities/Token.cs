namespace KhalalFoodDelivery.Application.Models.Entities;

internal class Token
{
    public Token(string tokenValue, DateTime expiryDate, Customer customer)
    {
        TokenValue = tokenValue;
        ExpiryDate = expiryDate;
        Customer = customer ?? throw new ArgumentNullException(nameof(customer));
        CustomerId = customer.Id;
    }

    public string TokenValue { get; set; }

    public DateTime ExpiryDate { get; set; }

    public Guid CustomerId { get; set; }

    public Customer Customer { get; set; }
}