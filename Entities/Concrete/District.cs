using Dapper.Contrib.Extensions;

namespace Entities.Concrete;
[Table("Districts")]
public class Distric
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
