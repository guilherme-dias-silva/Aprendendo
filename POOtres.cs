System.Console.WriteLine("Escolha uma peça do carro");
System.Console.WriteLine($"{Carro.Motor} - {(int)Carro.Motor}");
System.Console.WriteLine($"{Carro.Roda} - {(int)Carro.Roda}");
System.Console.WriteLine($"{Carro.Aro} - {(int)Carro.Aro}");
System.Console.WriteLine($"{Carro.Freio} - {(int)Carro.Freio}");

int valor = Convert.ToInt32(Console.ReadLine());

var chave = (Carro)valor;
Console.WriteLine($"Voce selecionou a categoria {chave.ToString()}");

Console.ReadKey();

enum Carro
{
    Motor,
    Roda,
    Aro,
    Freio
}