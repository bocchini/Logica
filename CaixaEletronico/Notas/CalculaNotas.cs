using System.Collections.Generic;

namespace CaixaEletronico.Notas
{
    public class CalculaNotas
    {
        private Dictionary<string, int> Notas = new Dictionary<string, int>();

        public void Calcular(decimal valor)
        {
            INotas cem = new Cem();
            INotas cinquenta = new Cinquenta();

            cem.Proxima = cinquenta;
            cem.Calcula(valor);          
        }

        public void SetNotas(string nota, int valor)
        {
            Notas.Add(nota, valor);
        }

        public Dictionary<string, int> GetNotas()
        {
            return Notas;
        }

    }
}
