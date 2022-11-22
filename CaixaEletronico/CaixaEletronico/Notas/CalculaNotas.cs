using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CaixaEletronico.Notas
{
    public class CalculaNotas
    {
        public IDictionary<string, int> Calcular(decimal valor)
        {
            var cem = new Cem(new Cinquenta(new Dez()));
            return cem.Calcula(valor, new Dictionary<string, int>());
        }
    }
}
