using Diamante;

Console.WriteLine("Digite uma letra");
var letra = Console.ReadLine().ToUpper();

var diamont = new Diamond().Create(letra);
foreach (var item in diamont)
{
    Console.WriteLine(item);
}
Console.ReadLine();

