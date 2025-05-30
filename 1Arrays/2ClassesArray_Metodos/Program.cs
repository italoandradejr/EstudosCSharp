

using System.Net.Http.Headers;

string[] nomes = new string[5] { "Ana", "Italo", "Rachel", "Gabriel", "Bete" };

Console.WriteLine($"\n\nExibindo o array original...");
ExibirArray(nomes);

Console.WriteLine($"\n\nInverter a ordem do array original...");
Array.Reverse(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nOrdenando o array...");
Array.Sort(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array...");
Console.WriteLine("Informe o nome: ");
string nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if(indice >=0)
    Console.WriteLine($"\n{nome} foi encontrado com índice = {indice}");
else
    Console.WriteLine($"\n{nome} Não foi encontrado");


    Console.ReadKey();

static void ExibirArray (string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($"{nome}");
    }
}