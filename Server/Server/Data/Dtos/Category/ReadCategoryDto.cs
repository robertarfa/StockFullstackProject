using System.ComponentModel.DataAnnotations;

namespace Server.Data.Dtos.Customer
{
    public class ReadCategoryDto
    {

        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
