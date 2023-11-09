using AutoMapper;
using Business.Abstract;
using DataAccesss.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Shared.Results;
using Shared.Utitilies.Security.Hashing;

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
            HashingHelper.CreatePasswordHash(model.Password, out var passwordHash, out var passwordSalt);

            var entity = _mapper.Map<Customer>(model);

            entity.PasswordHash = passwordHash;
            entity.PasswordSalt = passwordSalt;

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
        catch
        {
            return new BaseDataResponse<IEnumerable<CustomerDto>>(Enumerable.Empty<CustomerDto>(), false, "An error occurred while getting customers.");
        }
    }
}
