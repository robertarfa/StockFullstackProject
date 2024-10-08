using Server.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class ProductModel
    {
        private decimal discount;
        public const decimal MAX_DISCOUNT = 0.3m;

        public ProductModel(string name, string? description, int categoryId, int quantity, decimal price)
        {
            Name = name;
            Description = description;
            CategoryId = categoryId;
            Quantity = quantity;
            Price = price;
        }

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

        public decimal Discount
        {
            get => discount;
            set
            {
                discount = value;
                if (discount >= Price)
                {
                    //Desconto máximo de 30%
                    Price *= (1 - MAX_DISCOUNT);
                }
                else
                {
                    Price -= discount;

                }
            }
        }
    }
}
