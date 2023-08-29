using System;

namespace std;

public class Program{

static void Main(string[] args)
{
     
    Console.WriteLine("Em que bairro você mora?");
    var Bairro = Console.ReadLine();

    switch(Bairro)
    {
        case "Turmalina":
        case "Planalto":
        case "Palmeiras":
         Console.WriteLine("Você é do Sul de Valadares");
       break;
        case "Lagoa Santa":
        case "Perola":
        case "Gra duquesa":
         Console.WriteLine("Você é do Leste de Valadares");
       break;
        case "Carapina":
        case "Esplanada":
        case "Centro":
         Console.WriteLine("Você é da regiao central de Valadares");
       break;
    }
       Console.ReadKey();
}
}