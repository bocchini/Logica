using Mictorios.Interface;

namespace Mictorios.Homens
{
    public class GeradorMijoes : IGerador
    {
        private readonly int quantidadeMaxima = 10;

        public int Gera(int? mijoes = null)
        {
            return mijoes == null ? 
                new Random().Next(1, quantidadeMaxima) :
                (int)mijoes;
        }
    }
}
