using Dapper.Contrib.Extensions;
using Shared.Entities;

namespace Entities.Concrete;
[Table("VariantValues")]
public class Variants : BaseEntity
{
    public string Name { get; set; }
}
