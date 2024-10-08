using Server.Data.Dtos.Product;
using Server.Models;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace TestProject.ProductTests
{
    public class CreateProductModelTests
    {
        [Fact]
        public void Product_CreateAProductWithDiscount()
        {
            //Arrange
            ProductModel product = new(
                name: "Product",
                description: "Product description",
                categoryId: 1,
                quantity: 1,
                price: 100
            );

            decimal discount = 20;
            decimal priceWithDiscount = product.Price - discount;
            // Act
            product.Discount = discount;

            // Assert
            Assert.Equal(priceWithDiscount, product.Price);
        }

        [Fact]
        public void Product_CreateAProductWithMaxDiscountWhenDiscountBiggerThanPrice()
        {
            //Arrange
            ProductModel product = new(
                name: "Product",
                description: "Product description",
                categoryId: 1,
                quantity: 1,
                price: 100
            );

            decimal discount = 120;
            decimal priceWithDiscount = 70;
            // Act
            product.Discount = discount;

            // Assert
            Assert.Equal(priceWithDiscount, product.Price);
        }


    }
}
