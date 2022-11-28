using Mictorios.Homens;
using Mictorios.Interface;

namespace Mictorios.Tests
{
    public class GeradorMijoesTests
    {
        private IGerador mijoes;

        public GeradorMijoesTests()
        {
            mijoes = new GeradorMijoes();
        }

        [Fact]
        public void Deve_Gerar_Mijao_Setado()
        {
            var resultadoEsperado = 9;
            var resultado = mijoes.Gera(9);
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void Deve_Gerar_Quantidade_Randomica()
        {
            var resultado = mijoes.Gera();
            Assert.IsType<int>(resultado);
        }
    }
}
