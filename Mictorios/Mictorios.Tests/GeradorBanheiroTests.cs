using Mictorios.Banheiro;
using Mictorios.Interface;
using Mictorios.Mictorios;
using NSubstitute;

namespace Mictorios.Tests;

public class GeradorBanheiroTests
{
    private GeradorBanheiro banheiro;
	private IGerador geradorMictorios;

	public GeradorBanheiroTests()
	{
        geradorMictorios = Substitute.For<IGerador>();
        banheiro = new GeradorBanheiro(geradorMictorios);
	}

    [Theory()]
    [InlineData(6)]
    [InlineData(3)]
    public void Deve_Retornar_Quantidade_Mictorios(int quantidadeDeMictorios)
	{
		geradorMictorios.Gera().Returns(quantidadeDeMictorios);
		var resultado = banheiro.Gerar();
		Assert.Equal(quantidadeDeMictorios,resultado.Length);
	}
}
