using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.CategoryTests
{
    public class CategoryModelTests
    {
        [Fact]
        public void Category_CreateAValidCategory()
        {
            // Arrange
            string name = "Categoria Teste";

            // Act
            CategoryModel category = new(name);

            // Assert
            Assert.Equal(name, category.Name);
        }

    }
}
