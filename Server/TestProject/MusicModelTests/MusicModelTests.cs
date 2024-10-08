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
        [Theory]
        [InlineData("Música Teste")]
        [InlineData("Outra Música")]
        [InlineData("Mais uma Música")]
        public void InicializaNomeCorretamenteQuandoCastradaNovaMusica(string nome)
        {
            // Act
            MusicModel musica = new MusicModel(nome);

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

        [Theory]
        [InlineData("Música Teste", "Nome: Música Teste")]
        [InlineData("Outra Música", "Nome: Outra Música")]
        [InlineData("Mais uma Música", "Nome: Mais uma Música")]
        public void ExibeDadosDaMusicaCorretamenteQuandoChamadoMetodoExibeFichaTecnica
(string nome, string saidaEsperada)
        {
            // Arrange
            MusicModel musica = new MusicModel(nome);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            musica.ExibirFichaTecnica();
            string saidaAtual = stringWriter.ToString().Trim();

            // Assert
            Assert.Equal(saidaEsperada, saidaAtual);
        }

        [Theory]
        [InlineData(1, "Música Teste", "Id: 1 Nome: Música Teste")]
        [InlineData(2, "Outra Música", "Id: 2 Nome: Outra Música")]
        [InlineData(3, "Mais uma Música", "Id: 3 Nome: Mais uma Música")]
        public void ExibeDadosDaMusicaCorretamenteQuandoChamadoMetodoToString(int id, string nome, string toStringEsperado)
        {
            // Arrange
            MusicModel musica = new MusicModel(nome);
            musica.Id = id;

            // Act
            string resultado = musica.ToString();

            // Assert
            Assert.Equal(toStringEsperado, resultado);
        }

        [Fact]
        public void MusicYearCanNotBeNegativeOrZero()
        {
            //Arrange
            int invalidYear = -1900;

            MusicModel music = new("Music");

            //Act
            music.Year = invalidYear;
            //Assert
            Assert.Null(music.Year);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]

        public void MusicArtistCanNotBeNullOrEmpty(string? artist)
        {
            //Arrange
            MusicModel music = new("Music");

            //Act
            music.Artista = artist;
            //Assert
            Assert.Equal(music.Artista, "Artista desconhecido");
        }

    }
}
