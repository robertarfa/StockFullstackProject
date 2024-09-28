using Server.Data.Enums;
using Server.Models;
using System.ComponentModel.DataAnnotations;

namespace Server.Data.Dtos.Product
{
    public class ReadProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        public string CategoryName { get; set; }
        //public CategoryModel Category { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
