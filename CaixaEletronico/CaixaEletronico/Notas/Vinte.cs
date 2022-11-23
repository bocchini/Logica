namespace CaixaEletronico.Notas
{
    public class Vinte : INotas
    {
        private decimal ValorNota = 20;

        public INotas Proxima { get; set; }        

        public Vinte(INotas dez)
        {
            Proxima = dez;
        }

        public IDictionary<string, int> Calcula(decimal valor, IDictionary<string, int> notas)
        {
            var numeroNotas = (int) Math.Truncate(valor / ValorNota);
            valor -= numeroNotas * ValorNota;
            if(numeroNotas > 0)
            {
                notas.Add("Vinte", numeroNotas);
            }
            return Proxima.Calcula(valor, notas);
        }
    }
}
