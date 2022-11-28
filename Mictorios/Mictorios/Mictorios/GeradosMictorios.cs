using Mictorios.Interface;

namespace Mictorios.Mictorios
{
    public class GeradosMictorios : IGerador
    {
        private readonly int quantidadeMaxima = 10;

        public int Gera(int? mictorios = null)
        {
             return mictorios == null ? 
                new Random().Next(1, quantidadeMaxima): 
                (int)mictorios;
        }
    }
}
