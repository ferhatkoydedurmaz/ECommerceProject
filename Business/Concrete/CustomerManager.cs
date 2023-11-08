using AutoMapper;
using Business.Abstract;
using DataAccesss.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Shared.Results;

namespace Business.Concrete;
public class CustomerManager : ICustomerService
{
    private readonly IMapper _mapper;
    private readonly ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal, IMapper mapper)
    {
        _customerDal = customerDal;
        _mapper = mapper;
    }

    public async Task<BaseResponse> AddCustomerAsync(CustomerDto model)
    {
        try
        {
            var entity = _mapper.Map<Customer>(model);

            var result = await _customerDal.AddCustomerAsync(entity);

            return result ? new BaseResponse(true) : new BaseResponse(false, "Customer could not be added.");
        }
        catch
        {
            return new BaseResponse(false, "An error occurred while adding customer.");
        }
    }

    public async Task<BaseDataResponse<IEnumerable<CustomerDto>>> GetCustomersAsync()
    {
        try
        {
            var result = await _customerDal.GetCustomersAsync();

            return new BaseDataResponse<IEnumerable<CustomerDto>>(result, true);
        }
        catch(Exception ex)
        {
            return new BaseDataResponse<IEnumerable<CustomerDto>>(Enumerable.Empty<CustomerDto>(), false, "An error occurred while getting customers.");
        }
    }
}
