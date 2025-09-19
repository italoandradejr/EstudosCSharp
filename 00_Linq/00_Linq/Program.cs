Console.WriteLine("## Linq ##\n");

IList<string> frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };

//query syntax

var resultado = from f in frutas
                where f.Contains('r')
                select f;

Console.WriteLine(string.Join(" - ", resultado));

//method syntax
var resultado2 = frutas.Where(f => f.Contains('r'));

Console.WriteLine(string.Join(" - ", resultado2));


Console.ReadKey();