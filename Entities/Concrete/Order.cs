using Dapper.Contrib.Extensions;
using Shared.Entities;

namespace Entities.Concrete;
[Table("Orders")]
public class Order : BaseEntity
{
    public string OrderNumber { get; set; }
    public int CustomerId { get; set; }
}
