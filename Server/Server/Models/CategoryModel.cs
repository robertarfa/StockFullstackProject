using Server.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class CategoryModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Name { get; set; }



    }
}
