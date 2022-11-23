using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Notas
{
    public class Dez : INotas
    {
        public INotas Proxima { get; set; }
        private static decimal ValorNota = 10;

        public IDictionary<string, int> Calcula(decimal valor, IDictionary<string, int> notas)
        {
            var numeroNotas = (int)Math.Truncate(valor / ValorNota);

            if(numeroNotas > 0)
            {
                notas.Add("Dez", numeroNotas);
            }

            return notas;
        }
    }
}
