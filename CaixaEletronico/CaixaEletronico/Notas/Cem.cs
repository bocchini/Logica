using System.Collections.ObjectModel;

namespace CaixaEletronico.Notas
{
    public class Cem : INotas
    {
        public INotas Proxima { get; set; }

        private static decimal VALOR_NOTA = 100;

        public Cem(INotas cinquenta)
        {
            Proxima = cinquenta;
        }

        public IDictionary<string, int> Calcula(decimal valor, IDictionary<string, int> notas)
        {
            var numeroNotas = (int) Math.Truncate(valor / VALOR_NOTA);

            if (numeroNotas > 0)
            {
                notas.Add("Cem", numeroNotas);
            }

            valor = valor - numeroNotas * VALOR_NOTA;

            return Proxima.Calcula(valor, notas);
        }
    }
}
