using CaixaEletronico.Notas;
using FluentAssertions;

namespace CaixaEletronico.Testes;

public class TestesDoCalculaNotas
{
    private readonly CalculaNotas _calculaNotas;
    
    // pq no construtor?
    public TestesDoCalculaNotas()
    {
        _calculaNotas = new CalculaNotas();
    }
    
    [Fact]
    public void CalculaNotas_DeveRetornarUmaNotaDeCem_QuandoValorFor100()
    {
        var resultado = _calculaNotas.Calcular(100);
        resultado.Should().BeEquivalentTo(new Dictionary<string, int>()
        {
            {"Cem", 1}
        });
    }
    
    [Fact]
    public void CalculaNotas_DeveRetornarDuasNotasDeCem_QuandoValorFor200()
    {
        var resultado = _calculaNotas.Calcular(200);
        resultado.Should().BeEquivalentTo(new Dictionary<string, int>()
        {
            {"Cem", 2}
        });
    }
    
    [Fact]
    public void CalculaNotas_DeveRetornarUmaNotaDeCemEUmaDeCinquenta_QuandoValorFor150()
    {
        var resultado = _calculaNotas.Calcular(150);
        resultado.Should().BeEquivalentTo(new Dictionary<string, int>()
        {
            {"Cem", 1},
            {"Cinquenta", 1}
        });
    }
    
    [Fact]
    public void CalculaNotas_DeveRetornarUmaNotaDeDez_QuandoValorFor10()
    {
        var resultado = _calculaNotas.Calcular(10);
        resultado.Should().BeEquivalentTo(new Dictionary<string, int>()
        {
            {"Dez", 1}
        });
    }
}
