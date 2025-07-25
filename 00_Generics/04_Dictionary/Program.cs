
// formas de declara um dictionary, onde <int, int>(chave, valor)
using System.Net.Http.Headers;

Dictionary<int, int> dic1 = new Dictionary<int, int>();
var dic2 = new Dictionary<int, int>();

dic2.Add(2, 100);
dic2.Add(4, 200);
dic2.Add(3, 300);

var dic3 = new Dictionary<int, int>()
{
    {1,100},
    {2,100},
    {3,100}
};

try
{
    dic3.Add(3, 333);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("\n Usando o método tryAdd para a chave 3");
var resultado = dic3.TryAdd(3, 333);
Console.WriteLine("Elemento foi incluido? " + resultado);

Console.WriteLine("\nIncluindo o elemento com chave 7 valor 7000");
if (!dic3.ContainsKey(7))
{
    dic3.Add(7, 7000);
}

Console.WriteLine(dic3[7]);

Console.WriteLine("\nUsando ContainsValue");
if (dic3.ContainsValue(7000))
{
    Console.WriteLine("O valor existe no Dicionário");
}

Console.WriteLine("\nAlterando o valor do elemento com chave 7");
if (dic3.ContainsKey(7))
{
    dic3[7] = 7777;
}

Console.ReadKey();