using Dapper.Contrib.Extensions;

namespace TransferBetweenTwoTable.Models;
[Table("ATables")]
public class BTable
{
    [Key]
    public int Id { get; set; }
    public string Test1 { get; set; }
    public string Test2 { get; set; }
    public string Test3 { get; set; }
}
