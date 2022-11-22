using CaixaEletronico.Notas;

var value = 0m;

do
{
    Dictionary<string,int> list = new Dictionary<string, int>();
    Console.WriteLine("Digite quanto deseja retirar");

    value = Convert.ToDecimal(Console.ReadLine());

    var cem = 100.00m;
    var cinquenta = .50m;
    var vinte = .20m;
    var dez = .10m;
    CalculaNotas notas = new CalculaNotas();
    notas.Calcular(value);
    //list.Add(notas);
    /*
    var result = value / cem;
    list.Add("Cem:", (int)result);
    result -= Math.Truncate(result);

    while (result > 0.00m)
    {
        if (result >= cinquenta)
        {
            result = result / cinquenta;
            list.Add("Cinquenta:", (int)result);

        }
        else if (result >= vinte)
        {
            result = result / vinte;
            list.Add("Vinte:", (int)result);
        }
        else if (result >= dez)
        {
            result = result / dez;
            list.Add("Dez:", (int)result);
        }
        result -= Math.Truncate(result);
    }*/

    foreach (var item in notas.GetNotas())
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }
    Console.ReadLine();
}
while (value != 3);