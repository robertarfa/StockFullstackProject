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

        [Required(ErrorMessage = "O campo Tipo é obrigatório")]

        public ProductEnum.Category Category { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório")]

        public int Quantity { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório")]

        public decimal Price { get; set; }

    }
}
