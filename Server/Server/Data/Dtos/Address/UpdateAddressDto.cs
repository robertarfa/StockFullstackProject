using System.ComponentModel.DataAnnotations;

namespace Server.Data.Dtos.Address
{
    public class UpdateAddressDto
    {

        [Required(ErrorMessage = "A Cidade é obrigatória!")]
        public required string City { get; set; }
        [Required(ErrorMessage = "A Rua é obrigatória!")]
        public required string Street { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "O Número deve ser maior que zero.")]
        public required int Number { get; set; }
        public string? Complement { get; set; }
        [Required(ErrorMessage = "O Código Postal é obrigatório!")]
        public required string PostalCode { get; set; }


    }
}
