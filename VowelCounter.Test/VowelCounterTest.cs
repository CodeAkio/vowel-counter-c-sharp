using VowelCounter.Domain.Commands;

namespace VowelCounter.Tests
{
    [TestClass]
    public class ContadorDeVogaisTests
    {
        [TestMethod]
        public void ContadorDeVogais_DeveRetornarZeroQuandoTextoVazio()
        {
            // Arrange
            string texto = "";

            // Act
            int resultado = VowelCounterCommand.CountVowelsCommand(texto);

            // Assert
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void ContadorDeVogais_DeveRetornarZeroQuandoTextoSemVogais()
        {
            // Arrange
            string texto = "MSTest � uma ferramenta de teste unit�rio.";

            // Act
            int resultado = VowelCounterCommand.CountVowels(texto);

            // Assert
            Assert.AreEqual(16, resultado);
        }

        [TestMethod]
        public void ContadorDeVogais_DeveRetornarQuantidadeDeVogais()
        {
            // Arrange
            string texto = "OpenAI � incr�vel e inteligente!";

            // Act
            int resultado = VowelCounterCommand.CountVowels(texto);

            // Assert
            Assert.AreEqual(14, resultado);
        }

        [TestMethod]
        public void ContadorDeVogais_DeveIgnorarLetrasMaiusculas()
        {
            // Arrange
            string texto = "Programa��o Em C#";

            // Act
            int resultado = VowelCounterCommand.CountVowels(texto);

            // Assert
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void ContadorDeVogais_DeveContarAcentosEDiacriticos()
        {
            // Arrange
            string texto = "Voc� j� ouviu falar de �mlaut?";

            // Act
            int resultado = VowelCounterCommand.CountVowels(texto);

            // Assert
            Assert.AreEqual(12, resultado);
        }
    }
}
