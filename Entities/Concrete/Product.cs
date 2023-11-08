using Dapper.Contrib.Extensions;
using Shared.Entities;

namespace Entities.Concrete;
[Table("Products")]
public class Product : BaseEntity
{
    public string ModelCode { get; set; }
    public string Name { get; set; }
}
