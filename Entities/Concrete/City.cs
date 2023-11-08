using Dapper.Contrib.Extensions;
using Shared.Entities;

namespace Entities.Concrete;
[Table("Cities")]
public class City
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
