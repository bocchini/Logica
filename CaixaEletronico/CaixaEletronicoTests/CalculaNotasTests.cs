using CaixaEletronico.Notas;

namespace CaixaEletronicoTests
{
    public class CalculaNotasTests
    {
        private readonly CalculaNotas calculaNotas;

        public CalculaNotasTests()
        {
            calculaNotas = new CalculaNotas();
        }

        [Fact]
        public void DeveTestarOValorDuzentosRetornar2Notas()
        {
            var resultado = calculaNotas.Calcular(200);
            Assert.Equal(new Dictionary<string, int>() { { "Cem", 2 } }, resultado);
        }

        [Fact]
        public void DeveTestarOValorCemRetornarUmaNota()
        {
            var resultado = calculaNotas.Calcular(100);
            Assert.Equal(new Dictionary<string, int>() { { "Cem", 1 } }, resultado);
        }

        [Fact]
        public void DeveTestarOValorDuzentosCinquentaRetornarDuasNotaCemUmaNotaCinquenta()
        {
            var resultado = calculaNotas.Calcular(250);
            Assert.Equal(new Dictionary<string, int>() { { "Cem", 2 }, { "Cinquenta", 1 } }, resultado);
        }

        [Fact]
        public void DeveTestarOValorCemCinquentaRetornarUmaNotaCemUmaNotaCinquenta()
        {
            var resultado = calculaNotas.Calcular(150);
            Assert.Equal(new Dictionary<string, int>() { { "Cem", 1 }, { "Cinquenta", 1 } }, resultado);
        }

        [Fact]
        public void DeveTestarOValorCinquentaRetornarUmaNotaCinquenta()
        {
            var resultado = calculaNotas.Calcular(50);
            Assert.Equal(new Dictionary<string, int>() { { "Cinquenta", 1 } }, resultado);
        }

        [Fact]
        public void DeveTestarOValorCemSetentaRetornarUmaNotaCemUmaNotaCinquentaUmaVinte()
        {
            var resultado = calculaNotas.Calcular(170);
            Assert.Equal(new Dictionary<string, int>() { { "Cem", 1 }, { "Cinquenta", 1 }, { "Vinte", 1 } }, resultado);
        }

        [Fact]
        public void DeveTestarOValorCemNoventaRetornarUmaNotaCemUmaNotaCinquentaDuasVinte()
        {
            var resultado = calculaNotas.Calcular(190);
            Assert.Equal(new Dictionary<string, int>() { { "Cem", 1 }, { "Cinquenta", 1 }, { "Vinte", 2 } }, resultado);
        }

        [Fact]
        public void DeveTestarOValorVinteRetornarUmaNotaVinte()
        {
            var resultado = calculaNotas.Calcular(20);
            Assert.Equal(new Dictionary<string, int>() { { "Vinte", 1 } }, resultado);
        }

        [Fact]
        public void DeveTestarOValorCemVinteRetornarUmaNotaCemUmaVinte()
        {
            var resultado = calculaNotas.Calcular(120);
            Assert.Equal(new Dictionary<string, int>() { { "Cem", 1 }, { "Vinte", 1 } }, resultado);
        }


        [Fact]
        public void DeveTestarOValorDezVinteRetornarUmaNotaCemUmaDez()
        {
            var resultado = calculaNotas.Calcular(110);
            Assert.Equal(new Dictionary<string, int>() { { "Cem", 1 }, { "Dez", 1 } }, resultado);
        }

        [Fact]
        public void DeveTestarOValorDezRetornarUmaNotaDez()
        {
            var resultado = calculaNotas.Calcular(10);
            Assert.Equal(new Dictionary<string, int>() { { "Dez", 1 } }, resultado);
        }


        [Fact]
        public void DeveTestarOValorQuatrocentosOitentaRetornarQuatroCemUmaNotaCinquentaUmaVinteUmaDez()
        {
            var resultado = calculaNotas.Calcular(480);
            Assert.Equal(new Dictionary<string, int>() { { "Cem", 4 }, { "Cinquenta", 1 }, { "Vinte", 1 }, { "Dez", 1 }, }, resultado);
        }
    }
}