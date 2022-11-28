using Mictorios.Interface;
using Mictorios.Mictorios;

namespace Mictorios.Tests
{
    public class GeradorMictoriosTests
    {
        private IGerador mictorios;

        public GeradorMictoriosTests()
        {
            mictorios = new GeradosMictorios();
        }

        [Fact]
        public void Deve_Gerar_Quantidade_MICTORIOS_PASSADOS()
        {
            var resultadoEsperado = 5;
            var resultado = mictorios.Gera(5);

            resultadoEsperado.Equals(resultado);
        }

        [Fact]
        public void DEVE_GERAR_QUAr54NTIDADE_RANDOMICA()
        {
            var resultado = mictorios.Gera();
            Assert.IsType<int>(resultado);
        }
    }
}