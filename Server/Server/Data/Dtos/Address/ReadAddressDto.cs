using System.ComponentModel.DataAnnotations;

namespace Server.Data.Dtos.Address
{
    public class ReadAddressDto
    {

        public required string City { get; set; }

        public required string Street { get; set; }

        public required int Number { get; set; }
        public string? Complement { get; set; }

        public required string PostalCode { get; set; }
    }
}
