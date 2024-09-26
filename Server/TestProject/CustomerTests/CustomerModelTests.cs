using Server.Models;
using System.ComponentModel.DataAnnotations;

namespace TestProject.CustomerTests
{
    public class CustomerTests
    {
        [Fact]
        public void Customer_ShouldCreateValidInstance()
        {
            // Arrange
            var customer = new Customer
            {
                Name = "Nome do Cliente",
                PhoneNumber = "1234567890",
                Active = true,
                Address = new Address
                {
                    Street = "Rua Teste",
                    Number = 123,
                    City = "Cidade",
                    PostalCode = "12345-678"
                }
            };

            // Act & Assert
            Assert.NotNull(customer);
            Assert.Equal("Nome do Cliente", customer.Name);
            Assert.Equal("1234567890", customer.PhoneNumber);
            Assert.True(customer.Active);
            Assert.NotNull(customer.Address);
        }

        [Theory]
        [InlineData("", "1234567890", false)]
        [InlineData("Nome", "1234567890", false)]
        [InlineData("Nome do Cliente", "", false)]
        [InlineData("", "", false)]
        public void Customer_ShouldNotCreateInvalidInstance(string name, string phoneNumber, bool isValid)
        {
            // Arrange & Act
            var customer = new Customer
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Address = new Address
                {
                    Street = "Rua Teste",
                    Number = 123,
                    City = "Cidade",
                    PostalCode = "12345-678"
                }
            };

            // Assert
            if (!isValid)
            {
                Assert.ThrowsAny<ArgumentException>(() => customer.Validate());
            }
        }



    }
}
