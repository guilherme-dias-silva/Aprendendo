using System;

namespace std;

public class Program{

    static void Main(string[] args){
   
    int numero;
    int contador = 1;
    Console.WriteLine("Digite um numero maior que zero");
    numero = Convert.ToInt32(Console.ReadLine());

if(numero > 0)
{
  Console.WriteLine($"\n## Tabuada do {numero} ##\n");
  while(contador <= 10)
  {
    Console.WriteLine($"{numero} x {contador} = {numero*contador}");
    contador++;
  }
}
else
{
   Console.WriteLine("Digite um numero maior que zero!");
}

Console.ReadKey();
}
}