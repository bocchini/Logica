namespace CaixaEletronico.Notas
{
    public interface INotas
    {
        INotas Proxima { get; set; }
        IDictionary<string, int> Calcula(decimal valor, IDictionary<string, int> notas);
    }
}
