namespace Jokenpo.Jogadas
{
    internal class Tesoura : ICartas
    {
        static string percoDe = "Papel";
        public string Verifica(string jodada)
        {
            if (jodada == percoDe) return "Ganhou";
            return "Perdeu";
        }
    }
}
