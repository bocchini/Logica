namespace CaixaEletronico.Notas
{
    public class Cem : INotas
    {
        public INotas Proxima { get; set; }
        private static decimal ValorNota= 100;

        public Cem(INotas cinquenta)
        {
            Proxima = cinquenta;
        }

        public IDictionary<string, int> Calcula(decimal valor, IDictionary<string, int> notas)
        {
            var numeroNotas = (int) Math.Truncate(valor / ValorNota);
            valor -= numeroNotas *  ValorNota;
            
            if(numeroNotas > 0)
            {
                notas.Add("Cem", numeroNotas);
            }
            return Proxima.Calcula(valor, notas);
        }       
    }
}
