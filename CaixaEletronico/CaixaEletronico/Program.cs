using CaixaEletronico.Notas;

var value = 0m;

do
{
    Console.WriteLine("Digite quanto deseja retirar");

    value = Convert.ToDecimal(Console.ReadLine());

    CalculaNotas calcular = new CalculaNotas();
    var notas = calcular.Calcular(value);

    foreach (var item in notas)
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }
    Console.ReadLine();
}
while (value != 3);