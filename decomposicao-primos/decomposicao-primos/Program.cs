// See https://aka.ms/new-console-template for more information
using decomposicao_primos;

Console.WriteLine("Calucule A decomposição do numero");

Console.WriteLine("Digite o número: ");
var numero = Console.ReadLine();

var resultado = new Decompor(Convert.ToInt32(numero)).Calcular();
foreach (var item in resultado)
    Console.Write(item + ", ");