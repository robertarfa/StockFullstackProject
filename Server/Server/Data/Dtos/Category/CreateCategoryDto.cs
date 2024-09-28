using System.ComponentModel.DataAnnotations;

namespace Server.Data.Dtos.Category
{
    public class CreateCategoryDto
    {

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Name { get; set; }

    }
}
