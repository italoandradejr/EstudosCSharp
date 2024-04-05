using System;
using System.Threading.Channels;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) // responsável por percorrer as linhas da matriz
            {
                string[] valores = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)  // responsável por percorrer as colunas da matriz, e será executado para cada uma das linhas
                {
                    mat[i,j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal principal:");

            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();


            int contagem = 0;
            for(int i = 0;i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        contagem++;
                    }
                }
            }

            Console.WriteLine("Números negatigos: " + contagem);
        }
    }
}