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

        [Fact]
        public void Product_ThrowAErrorWhenCreatingAProductWithoutName()
        {
            //Arrange
            CreateProductDto product = new(
                name: "",
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
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage == "O campo Nome é obrigatório");
        }

        [Fact]
        public void Product_ThrowAErrorWhenCreatingAProductWithAInvalidCategory()
        {
            //Arrange
            CreateProductDto product = new(
                name: "Product",
                description: "Product description",
                categoryId: 0,
                quantity: 1,
                price: 20
            );

            var context = new ValidationContext(product);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(product, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage == "O campo Categoria é obrigatório.");
        }

        [Fact]
        public void Product_ThrowAErrorWhenCreatingAProductWithAInvalidQuantity()
        {
            //Arrange
            CreateProductDto product = new(
                name: "Product",
                description: "Product description",
                categoryId: 1,
                quantity: 0,
                price: 20
            );

            var context = new ValidationContext(product);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(product, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage == "O campo Quantidade é obrigatório.");
        }

        [Fact]
        public void Product_ThrowAErrorWhenCreatingAProductWithAInvalidPrice()
        {
            //Arrange
            CreateProductDto product = new(
                name: "Product",
                description: "Product description",
                categoryId: 1,
                quantity: 1,
                price: 0
            );

            var context = new ValidationContext(product);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(product, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage == "O campo Valor é obrigatório.");
        }
    }
}
