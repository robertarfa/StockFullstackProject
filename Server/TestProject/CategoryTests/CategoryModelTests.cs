using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.CategoryTests
{
    public class ProductModelTests
    {
        [Fact]
        public void Category_CreateAValidCategory()
        {
            // Arrange
            string name = "Categoria Teste";
            int id = 13;

            // Act
            CategoryModel category = new(id, name);

            // Assert
            Assert.Equal(id, category.Id);
        }

    }
}
