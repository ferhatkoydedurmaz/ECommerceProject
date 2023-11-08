using Dapper.Contrib.Extensions;
using Shared.Entities;

namespace Entities.Concrete;
[Table("BasketProducts")]
public class BasketProduct:BaseEntity
{
    public int BasketId { get; set; }
    public int ProductId { get; set; }
    public int ProductVariantId { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
}
