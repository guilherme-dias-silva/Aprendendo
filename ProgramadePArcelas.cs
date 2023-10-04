using System;

namespace std;

class Program{

    static void Main(){

    System.Console.WriteLine("Calculadora de parcelas");
    int numeroParcelas = Convert.ToInt32(Console.ReadLine());
    int valor = 600;

    switch(numeroParcelas){
    
    case 1:
    Console.WriteLine($"Valor da parcela é {valor / numeroParcelas}");
    break;

    case 2:
    Console.WriteLine($"Valor da parcela é {valor / numeroParcelas}");
    break;

    case 3:
    Console.WriteLine($"Valor da parcela é {valor / numeroParcelas}");
    break;

    case 4:
    Console.WriteLine($"Valor da parcela é {valor / numeroParcelas}");
    break;

    default:
    Console.WriteLine("Digite uma parcela existente");
    break;
    }
    Console.ReadKey();
    }
}