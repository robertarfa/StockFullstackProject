using Server.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Server.Data.Dtos.Product
{
    public class ReadProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        //public ProductEnum.Category Category { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
