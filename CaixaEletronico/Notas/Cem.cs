namespace CaixaEletronico.Notas
{
    public class Cem : INotas
    {
        public INotas Proxima { get; set; }
        private static decimal Nota= 100;

        public Dictionary<string, int> Calcula(decimal valor)
        {
            var result = valor / Nota;
            var rest = result - Math.Truncate(result);
            
            new CalculaNotas().SetNotas("Cem", (int)result);
            if (Decimal.Compare(rest, 0) == 1)
            {
                return Proxima.Calcula(rest);
            }
            return new Dictionary<string, int>()
           {
                {"Cem", (int)result }
           };
        }       
    }
}
