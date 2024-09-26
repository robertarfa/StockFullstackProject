using Microsoft.EntityFrameworkCore;
using Server.Data.Dtos.Address;
using Server.Models;
using System.ComponentModel.DataAnnotations;

namespace Server.Data.Dtos.Customer;

public class CreateCustomerDto
{


    [Required(ErrorMessage = "O Nome é obrigatório!")]
    //StringLength não aloca memória dentro do banco
    [StringLength(120, MinimumLength = 5, ErrorMessage = "O Nome não pode ser menor do que 5 caracteres!")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "O Celular é obrigatório!")]

    public required string PhoneNumber { get; set; }

    public bool Active { get; set; }

    public required CreateAddressDto Address { get; set; }


}
