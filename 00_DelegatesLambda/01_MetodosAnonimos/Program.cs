
Imprimir imprimir = delegate (int valor)
{
    Console.WriteLine($"Método Anônimo: {valor}");
};

imprimir(100);
imprimir(200);

Console.ReadKey();

public delegate void Imprimir(int valor);