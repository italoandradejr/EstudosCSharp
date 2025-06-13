

//declarei e aloquei memoria para o array
string[,] alunos = new string[2, 5];

Console.WriteLine("\nAtribuindo dados a um array de strings com 2 linhas e 5 colunas [2,5]\n");



for (int i = 0; i < alunos.GetLength(0); i++) // refere-se a 1 dimenssão do array (linha)
{
    for (int j = 0; j < alunos.GetLength(1); j++) // refere-se a 2 dimenssão do array (coluna)
    {
        Console.WriteLine($"Informe o valor para o elemento na posição [{i},{j}]");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nconteúdo do array alunos\n");

for (int i = 0; i < alunos.GetLength(0); i++) 
{
    for (int j = 0; j < alunos.GetLength(1); j++) 
    {
        Console.WriteLine();
    }
}