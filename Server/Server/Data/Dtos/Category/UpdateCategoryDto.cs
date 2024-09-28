using System.ComponentModel.DataAnnotations;

namespace Server.Data.Dtos.Category
{
    public class UpdateCategoryDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Name { get; set; }

    }
}
