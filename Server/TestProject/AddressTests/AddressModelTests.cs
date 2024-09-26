using Server.Models;
using Xunit;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TestProject.AddressTests
{
    public class AddressTests
    {
        [Fact]
        public void Address_ValidProperties_ShouldPassValidation()
        {
            // Arrange
            var address = new Address
            {
                Id = 1,
                City = "Cidade Teste",
                Street = "Rua Teste",
                Number = 123,
                Complement = "Apto 101",
                PostalCode = "12345-678"
            };

            var context = new ValidationContext(address);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(address, context, results, true);

            // Assert
            Assert.True(isValid);
            Assert.Empty(results);
        }

        [Fact]
        public void Address_NumberLessThanOne_ShouldFailValidation()
        {
            // Arrange
            var address = new Address
            {
                Id = 1,
                City = "Cidade Teste",
                Street = "Rua Teste",
                Number = 0, // Número inválido
                Complement = "Apto 101",
                PostalCode = "12345-678"
            };

            var context = new ValidationContext(address);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(address, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Single(results);
            Assert.Equal("O Número deve ser maior que zero.", results.Single().ErrorMessage);
        }
    }
}