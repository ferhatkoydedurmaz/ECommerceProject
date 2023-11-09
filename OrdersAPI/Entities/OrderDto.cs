namespace OrdersAPI.Entities;

public class OrderDto
{
    public int OrderId { get; set; }
    public string OrderNumber { get; set; }
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime CreatedAt { get; set; }
}
