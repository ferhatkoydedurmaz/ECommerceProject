using Dapper.Contrib.Extensions;
using Shared.Entities;

namespace Entities.Concrete;
[Table("CustomerAddresses")]
public class CustomerAddress : BaseEntity
{
    public int CustomerId { get; set; }
    public int CityId { get; set; }
    public int DistrictId { get; set; }
    public string Address { get; set; }
}
