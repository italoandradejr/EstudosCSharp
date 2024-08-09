using System;
using System.IO;

namespace CopiaArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoDeOrigem = @"C:\Users\italo.andrade\Downloads\fire1.txt";
            string caminhoDeDestino = @"C:\Users\italo.andrade\Downloads\fire2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(caminhoDeOrigem);
                fileInfo.CopyTo(caminhoDeDestino);


                //cria um vetor de strings
                string[] linhas = File.ReadAllLines(caminhoDeOrigem);
                foreach (string line in linhas)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}

