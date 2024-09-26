using Microsoft.EntityFrameworkCore;
using Server.Data;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Server.Models
{
    public class Customer
    {
        //Fazer a validação do phoneNumber no service
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório!")]
        [MinLength(5, ErrorMessage = "O Nome não pode ser menor do que 5 caracteres!")]
        public required string Name { get; set; }


        [Required(ErrorMessage = "O Telefone é obrigatório!")]
        public required string PhoneNumber { get; set; }

        public bool Active { get; set; }

        //public int AddressId { get; set; }
        public required Address Address { get; set; }


        public void Validate()
        {
            var context = new ValidationContext(this, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(this, context, results, true))
            {
                var errorMessage = string.Join("\n", results.Select(x => x.ErrorMessage));
                throw new ArgumentException(errorMessage);
            }
        }
    }
}
