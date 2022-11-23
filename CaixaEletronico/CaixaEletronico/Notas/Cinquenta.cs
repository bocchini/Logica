namespace CaixaEletronico.Notas
{
    public class Cinquenta : INotas
    {
        public INotas Proxima { get; set; }
        private static decimal ValorNota = 50;

        public Cinquenta(INotas vinte)
        {
            Proxima = vinte;
        }

        public IDictionary<string, int> Calcula(decimal valor, IDictionary<string, int> notas)
        {
            var numeroNotas = (int)Math.Truncate(valor /ValorNota);            

            valor -= numeroNotas * ValorNota;

            if(numeroNotas > 0)
            {
                notas.Add("Cinquenta", numeroNotas);
            }

            return Proxima.Calcula(valor, notas);
        }
    }
}
