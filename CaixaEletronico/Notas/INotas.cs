namespace CaixaEletronico.Notas
{
    public interface INotas
    {
        INotas Proxima { get; set; }
        Dictionary<string, int> Calcula(decimal valor);
    }
}
