namespace CaixaEletronico.Notas;

public class Dez : INotas
{
    public INotas Proxima { get; set; }
    public IDictionary<string, int> Calcula(decimal valor, IDictionary<string, int> notas)
    {
        var numeroNotas = (int) Math.Truncate(valor / 10);

        if (numeroNotas > 0)
        {
            notas.Add("Dez", numeroNotas);
        }

        return notas;
    }
}
