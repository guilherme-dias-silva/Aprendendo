Regra p1 = new("Breno", 20);
Regra p2 = new("Bianca", 32);

System.Console.WriteLine($"{p1.Nome}\n{p1.Idade}\nIdade Minima: {Regra.IdadeMinima}");
System.Console.WriteLine($"{p2.Nome}\n{p2.Idade}\nIdade Minima: {Regra.IdadeMinima}");

Console.ReadKey();
class Regra
{
   public string Nome = string.Empty;
   public int Idade;

   public static int IdadeMinima;

   public Regra(string nome, int idade)
   {
     Nome = nome;
     Idade = idade;
   }
   public Regra()
   {}
   static Regra()
   {
      System.Console.WriteLine("Inicializindo static");
      IdadeMinima = 18;
   }
}