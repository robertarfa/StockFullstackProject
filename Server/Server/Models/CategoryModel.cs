using Server.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class CategoryModel
    {

        // Construtor padrão (sem parâmetros)
        // public CategoryModel() { }

        public CategoryModel(string name)
        {

            Name = name;
        }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Name { get; set; }

    }
}
