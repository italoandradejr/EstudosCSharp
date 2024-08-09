using System;
using System.IO;
using System.Collections.Generic;

namespace DiretorioArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\italo.andrade\Downloads\teste";

            try
            {
                var pastas = Directory.EnumerateDirectories(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas: ");
                foreach (string s in pastas)
                {
                    Console.WriteLine(s);
                }


                var arquivos = Directory.EnumerateFiles(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Arquivos: ");
                foreach (string s in arquivos)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(caminho + @"\pastaNova");

            }
            catch (IOException ex) 
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(ex.Message);
            }


        }
    }
}