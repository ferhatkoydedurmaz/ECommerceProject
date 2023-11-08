using Dapper.Contrib.Extensions;
using Shared.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete;
[Table("Customers")]
public class Customer : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public int InvoiceAddressId { get; set; }
    public int ShippingAddressId { get; set; }
}
