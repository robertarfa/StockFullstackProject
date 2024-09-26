using Server.Data.Dtos.Address;
using Server.Models;

namespace Server.Data.Dtos;

public class ReadCustomerDto
{

    public required string Name { get; set; }

    public required string PhoneNumber { get; set; }

    public bool Active { get; set; }

    public required ReadAddressDto Address { get; set; }

}
