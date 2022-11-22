using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Notas
{
    public class Cinquenta : INotas
    {
        public Cinquenta(INotas dez)
        {
            Proxima = dez;
        }

        public INotas Proxima { get; set; }

        public IDictionary<string, int> Calcula(decimal valor, IDictionary<string, int> notas)
        {
            var numeroNotas = (int) Math.Truncate(valor / 50);

            if (numeroNotas != 0)
            {
                notas.Add("Cinquenta", numeroNotas);
            }

            valor = valor - numeroNotas * 50;
            return Proxima.Calcula(valor, notas);
        }
    }
}
