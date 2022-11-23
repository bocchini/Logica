using System.Collections.Generic;

namespace CaixaEletronico.Notas
{
    public class CalculaNotas
    {        
        public IDictionary<string, int> Calcular(decimal valor)
        {
            INotas cem = new Cem(new Cinquenta(new Vinte(new Dez())));

           return cem.Calcula(valor, new Dictionary<string, int>());          
        }
    }
}
