using System.Data.SqlTypes;

namespace OrdersAPI.Entities;

public class OrderFilterSearchKeys
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime OrderStartDate { get; set; } = SqlDateTime.MinValue.Value;
    public DateTime OrderEndDate { get; set; } = SqlDateTime.MaxValue.Value;

}
