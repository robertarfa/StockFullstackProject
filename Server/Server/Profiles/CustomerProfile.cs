using AutoMapper;
using Server.Data.Dtos;
using Server.Data.Dtos.Customer;
using Server.Models;

namespace Server.Profiles;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CreateCustomerDto, Customer>();
        CreateMap<UpdateCustomerDto, Customer>();
        CreateMap<Customer, UpdateCustomerDto>();
        CreateMap<Customer, ReadCustomerDto>();

    }
}
