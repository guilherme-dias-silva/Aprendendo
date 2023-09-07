using System;

namespace DoWhile;

public class DoWhile{

    static void Main(string[] args){

    int x = 0;

    do
    {
        int y = 0;
    do
    {
        Console.Write($"({x},{y})");
        y++;
    }
    while( y < 5);
    x++;
    Console.WriteLine();
    }
    while(x < 5);

    Console.ReadKey();
    

}
}