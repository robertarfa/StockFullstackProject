using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.CategoryTests
{
    public class MusicModelTests
    {
        [Fact]
        public void Music_ValidateName()
        {
            // Arrange
            string nome = "Música Teste";

            // Act
            MusicModel musica = new(nome);

            // Assert
            Assert.Equal(nome, musica.Nome);
        }

        [Fact]
        public void Music_TestIdInitializedCorrectly()
        {
            // Arrange
            string nome = "Música Teste";
            int id = 13;

            // Act
            MusicModel musica = new(nome) { Id = id };

            // Assert
            Assert.Equal(id, musica.Id);
        }

        [Fact]
        public void Music_TestToString()
        {
            // Arrange
            int id = 1;
            string nome = "Música Teste";
            MusicModel musica = new(nome)
            {
                Id = id
            };

            string toStringEsperado = @$"Id: {id} Nome: {nome}";

            // Act
            string resultado = musica.ToString();

            // Assert
            Assert.Equal(toStringEsperado, resultado);
        }
    }
}
