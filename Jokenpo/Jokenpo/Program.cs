using Jokenpo;
using Jokenpo.Jogadas;

var values = Enum.GetNames(typeof(IJogadas));

var jogadaRobo = values[new Random().Next(0, values.Length)];

Console.WriteLine($"Digite Pedra, Papel ou Tesoura para jogar");
var jogadaJogador = Console.ReadLine().Trim();

if (!String.IsNullOrEmpty(jogadaJogador) && values.Contains(jogadaJogador))
{
    if (jogadaRobo == jogadaJogador)
    {
        Console.WriteLine("Empate");
        return;
    }
    var resultado = "";
    switch (jogadaJogador)
    {
        case "Papel":
            resultado = new Papel().Verifica(jogadaRobo);
            Console.WriteLine(resultado);
            break;
        case "Tesoura":
            resultado = new Tesoura().Verifica(jogadaRobo);
            Console.WriteLine(resultado);
            break;
        case "Pedra":
            resultado = new Pedra().Verifica(jogadaRobo);
            Console.WriteLine(resultado);
            break;
    }
}
else
{                            
    Console.WriteLine(jogadaJogador);
    Console.ReadLine();
}