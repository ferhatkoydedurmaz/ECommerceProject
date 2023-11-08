using Entities.Dto;
using Shared.Results;

namespace Business.Abstract;
public interface ICustomerService
{
    Task<BaseResponse> AddCustomerAsync(CustomerDto model);
    Task<BaseDataResponse<IEnumerable<CustomerDto>>> GetCustomersAsync();
}
