using Mictorios.Interface;

namespace Mictorios.Banheiro
{
    public class GeradorBanheiro
    {
        private IGerador _gerador;

        public GeradorBanheiro(IGerador gerador)
        {
            _gerador = gerador;
        }

        public bool[] Gerar()
        {
            var quantidadeMictorios = _gerador.Gera();

            return new bool[quantidadeMictorios];
        }
    }
}
