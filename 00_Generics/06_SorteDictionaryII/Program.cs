
Console.WriteLine("\n### Criando o SortedDictionary ###");

var brics = new SortedDictionary<int, String>()
{
    {20,"Brasil" },
    {10,"China" },
    {40,"India" },
    {30,"URSS" }
};

Console.WriteLine("\nIncluindo o elemento de chava:70 e valor:África do sul");

if (brics.ContainsKey(70))
    Console.WriteLine("Chava já existente");
else
    brics.Add(70, "África do sul");

foreach (var pais in brics)
{
    Console.WriteLine($"Chave/valor: { pais.Key} {pais.Value }");
}

    Console.ReadKey();