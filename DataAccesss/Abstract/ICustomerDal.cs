using Entities.Concrete;
using Entities.Dto;

namespace DataAccesss.Abstract;
public interface ICustomerDal
{
    Task<IEnumerable<CustomerDto>> GetCustomersAsync();
    Task<bool> AddCustomerAsync(Customer model);
}
