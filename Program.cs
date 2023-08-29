using System;

namespace Projeto2;

public class Programa2{
    
    static void Main(string[] args){


    int bola = 1;

        Looop:

        Console.WriteLine($"Bola numero {bola}");
    
        if(bola<11){
        bola++;
        goto Looop;}
    
        Console.ReadKey();
}
}