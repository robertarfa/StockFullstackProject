using AutoMapper;
using Server.Data.Dtos;
using Server.Data.Dtos.Address;
using Server.Data.Dtos.Customer;
using Server.Models;

namespace Server.Profiles;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<CreateAddressDto, Address>();
        CreateMap<UpdateAddressDto, Address>();
        CreateMap<Address, UpdateAddressDto>();
        CreateMap<Address, ReadAddressDto>();

    }
}
