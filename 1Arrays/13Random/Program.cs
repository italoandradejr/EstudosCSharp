
Random aleatorio = new Random();

Console.WriteLine(aleatorio.Next()); // número aleatório gerador a partir dos números inteiros;
Console.WriteLine(aleatorio.Next(20)); // valor máximo 20.
Console.WriteLine(aleatorio.Next(10, 20)); // itervalo 10 a 20
Console.WriteLine(aleatorio.NextDouble()); // número aleatório entre 0 e 1


Console.WriteLine("\nSorteio da MegaSena\n");

int[] numerosSorteado = new int[6];// quantidade de 6 espações

for (int i = 0; i < 6; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = aleatorio.Next(1, 61);
    }
    while (numerosSorteado.Contains(numeroAleatorio)); 
    {
        numerosSorteado[i] = numeroAleatorio;
    }
}

Array.Sort(numerosSorteado);

Console.WriteLine("Números Sorteador\n");
Console.WriteLine(string.Join(" ", numerosSorteado));


Console.ReadKey();
