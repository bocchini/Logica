namespace Mictorios.Tests
{
    public class ControladorBanheiroTests
    {
        private readonly ControladorBanheiro _controladorBanheiro;

        public ControladorBanheiroTests()
        {
            _controladorBanheiro = new ControladorBanheiro();
        }

        [Fact]
        public void Deve_()
        {
            var quantidade = _controladorBanheiro.Controlar(3);

            Assert.Equal(2, quantidade.Where(q => q == true).Count());
        }
    }
}
