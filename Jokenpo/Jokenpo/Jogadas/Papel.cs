namespace Jokenpo
{
    public class Papel : ICartas
    {
        static string percoDe = "Pedra";

        public string Verifica(string jodada)
        {
            if(jodada == percoDe) return "Ganhou";
            return "Perdeu";
        }


    }
}
