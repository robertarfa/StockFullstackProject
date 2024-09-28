using Server.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class ProductModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O campo Categoria é obrigatório.")]
        public int CategoryId { get; set; } = 0;
        public CategoryModel Category { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório")]

        public int Quantity { get; set; } = 0;

        [Required(ErrorMessage = "O campo Valor é obrigatório")]

        public decimal Price { get; set; } = 0;

    }
}
