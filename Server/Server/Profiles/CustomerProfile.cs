using AutoMapper;
using Server.Data.Dtos;
using Server.Data.Dtos.Customer;
using Server.Models;

namespace Server.Profiles;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CreateCustomerDto, CustomerModel>();
        CreateMap<UpdateCustomerDto, CustomerModel>();
        CreateMap<CustomerModel, UpdateCustomerDto>();
        CreateMap<CustomerModel, ReadCustomerDto>();

    }
}
