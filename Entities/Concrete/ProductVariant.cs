using Dapper.Contrib.Extensions;
using Shared.Entities;

namespace Entities.Concrete;
[Table("ProductVariants")]
public class ProductVariant : BaseEntity
{
    public int ProductId { get; set; }
    public int VariantId { get; set; }
    public string StockCode { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}
