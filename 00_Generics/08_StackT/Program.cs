
Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);

Console.WriteLine($"A pilha original contém {numeros.Count} itens");

ExibirPilha(numeros);


Console.ReadKey();

static void ExibirPilha<T>(IEnumerable<T> numerosItem)
{
    foreach (var item in numerosItem)
    {
        Console.WriteLine(item);
    }

}

