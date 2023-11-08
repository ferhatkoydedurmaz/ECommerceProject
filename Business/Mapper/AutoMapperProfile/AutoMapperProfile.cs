using AutoMapper;
using Entities.Concrete;
using Entities.Dto;

namespace Business.Mapper.AutoMapperProfile;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Customer, CustomerDto>()
        .ReverseMap();


    }
}
