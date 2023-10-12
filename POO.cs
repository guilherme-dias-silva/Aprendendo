using System.Net;
using System.Runtime.ConstrainedExecution;

Aluno guilherme = new Aluno();

System.Console.WriteLine("Qual o seu nome?");
guilherme.Nome = Console.ReadLine();
System.Console.WriteLine("Sexo?");
guilherme.Sexo = Console.ReadLine();
System.Console.WriteLine("Idade?");
guilherme.Idade = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Sua nota:");
guilherme.Aprovado = Convert.ToInt32(Console.ReadLine());

Escola resultado = new Escola();
resultado.Nota(guilherme.Nome, guilherme.Sexo, guilherme.Idade, guilherme.Aprovado);

Console.ReadKey();

class Aluno
{
    public string? Nome;
    public string? Sexo;

    public int Idade;

    public int Aprovado;
}
class Escola
{
    public void Nota(string nome, string sexo, int idade, int aprovado)
    {
     Console.WriteLine($"O aluno {nome} do sexo {sexo} tem {idade} anos e ");
     if(aprovado > 7)
        Console.WriteLine("Foi aprovado");
     else
        Console.WriteLine("Foi reprovado");
    }
}