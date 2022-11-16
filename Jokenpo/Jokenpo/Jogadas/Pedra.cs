namespace Jokenpo.Jogadas
{
    public class Pedra : ICartas
    {
        static string ganhoDe = "Tesoura";
        public string Verifica(string jodada)
        {
            if (jodada == ganhoDe) return "Ganhou";
            return "Perdeu";
        }
    }
}
