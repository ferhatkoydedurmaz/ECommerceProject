using Shared.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Dto;
public class CustomerDto:BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(50)]
    public string Email { get; set; }
    [Required]
    [MaxLength(12)]
    public string Phone { get; set; }
    [Required]
    [MaxLength(64)]
    public string Password{ get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public int InvoiceAddressId { get; set; } = 0;
    public int ShippingAddressId { get; set; } = 0;
}
