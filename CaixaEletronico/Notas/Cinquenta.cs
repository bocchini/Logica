using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Notas
{
    public class Cinquenta : INotas
    {
        public INotas Proxima { get; set; }

        public Dictionary<string, int> Calcula(decimal valor)
        {
            var result = valor / .50m;
            var rest = result - Math.Truncate(result);
            new CalculaNotas().SetNotas("Cinquenta", (int)result);
            if (rest < 0.00m)
            {
                return Proxima.Calcula(rest);
            }
            return new Dictionary<string, int>()
           {
                {"Cinquenta", (int)result }
           };
        }
    }
}
