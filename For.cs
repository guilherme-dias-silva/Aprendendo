using System;

namespace std;

public class For{

    static void Main(string[] args){

    int resultado;
    int i;
    int numero;
    System.Console.WriteLine("Informe um numero inteiro");
    numero =  Convert.ToInt32(Console.ReadLine());


    for(i=1; i<=10; i++)
    {
        resultado = i * numero;
        System.Console.WriteLine($"{numero} x {i} = {resultado}");
    }
    Console.ReadKey();
}
}