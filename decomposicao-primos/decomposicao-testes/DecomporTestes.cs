using decomposicao_primos;

namespace decomposicao_testes
{
    public class DecomporTestes
    {        
        [Fact]
        public void Calcular_DeveRetornarCinco_QuandoNumeroCalculadorFor5()
        {
            var numero = 5;

            var resultado = new Decompor(numero).Calcular();

            Assert.Equal(resultado[0], 5);
        }

        [Fact]
        public void DeveRetornarLista2255_QuandoNumeroCalculadorFor100()
        {
            var numero = 100;
            var resultadoEsperado = new List<int> { 2, 2, 5, 5 };

            var resultado = new Decompor(numero).Calcular();
            Assert.Equivalent(resultado, resultadoEsperado);
        }

        [Fact]
        public void DeveRetornarLista23311_QuandoNumeroCalculadorFor198()
        {
            var numero = 198;
            var resultadoEsperado = new List<int> { 2, 3, 3, 11 };

            var resultado = new Decompor(numero).Calcular();
            Assert.Equivalent(resultado, resultadoEsperado);
        }


        [Fact]
        public void DeveRetornarLista23311_QuandoNumeroCalculadorFor276()
        {
            var numero = 276;
            var resultadoEsperado = new List<int> { 2, 2, 3, 23 };

            var resultado = new Decompor(numero).Calcular();
            Assert.Equivalent(resultado, resultadoEsperado);
        }
    }
}