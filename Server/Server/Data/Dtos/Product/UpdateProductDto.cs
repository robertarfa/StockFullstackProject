using Server.Data.Enums;
using Server.Models;
using System.ComponentModel.DataAnnotations;

namespace Server.Data.Dtos.Product
{
    public class UpdateProductDto
    {

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Name { get; set; }

        public string? Description { get; set; }


        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O campo Categoria é obrigatório.")]
        public int CategoryId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O campo Quantidade é obrigatório.")]
        public int Quantity { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O campo Valor é obrigatório.")]
        public decimal Price { get; set; }
    }
}
