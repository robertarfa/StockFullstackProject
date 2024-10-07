using Server.Data.Dtos.Product;
using Server.Models;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace TestProject.ProductTests
{
    public class CreateProductDtoTests
    {
        [Fact]
        public void Product_CreateAValidProduct()
        {
            //Arrange
            CreateProductDto product = new(
                name: "Product",
                description: "Product description",
                categoryId: 1,
                quantity: 1,
                price: 20
            );

            var context = new ValidationContext(product);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(product, context, results, true);

            // Assert
            Assert.True(isValid);
            Assert.Empty(results);
        }

        [Theory]
        [InlineData("", "Product description", 1, 1, 20, "O campo Nome é obrigatório")]
        [InlineData("Nome", "Product description", 0, 1, 20, "O campo Categoria é obrigatório.")]
        [InlineData("Nome", "Product description", 1, 0, 20, "O campo Quantidade é obrigatório.")]
        [InlineData("Nome", "Product description", 1, 1, 0, "O campo Valor é obrigatório.")]
        public void Product_CreatingAInvalidProduct_ThrowAError(
            string name,
            string description,
            int categoryId,
            int quantity,
            decimal price,
            string message)
        {
            //Arrange
            CreateProductDto product = new(
                name: name,
                description: description,
                categoryId: categoryId,
                quantity: quantity,
                price: price
            );

            var context = new ValidationContext(product);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(product, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage == message);
        }

    }
}
