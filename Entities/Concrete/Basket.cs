using Dapper.Contrib.Extensions;
using Shared.Entities;

namespace Entities.Concrete;
[Table("Baskets")]
public class Basket : BaseEntity
{
    public string OrderNumber{ get; set; }
    public bool IsOrdered { get; set; } = false;
}
