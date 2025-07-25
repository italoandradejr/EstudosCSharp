

using System.Collections.ObjectModel;

var planetas = new List<string>()
{
    "Mercúrio", "Vênus", "Terra", "Marte"
};

var listaPlanetas = new ReadOnlyCollection<string>(planetas);

Console.WriteLine("\nPlanetas não gasosos do sistema solar: ");

foreach(var planet in listaPlanetas)
{
    Console.WriteLine($"{planet}");
}

Console.WriteLine($"\n\nPlanetas na coleção: {listaPlanetas.Count}");

Console.ReadKey();