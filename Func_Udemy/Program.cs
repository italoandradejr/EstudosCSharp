using Func_Udemy.Entities;
using System;

namespace Func_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produtos> lista = new List<Produtos>();

            lista.Add(new Produtos("Tv", 900.00));
            lista.Add(new Produtos("Mouse", 50.00));
            lista.Add(new Produtos("Tablet", 350.50));
            lista.Add(new Produtos("Tv", 80.90));

            List<string> resultado = lista.Select(NomeUpper).ToList();
            foreach(string s in resultado)
            {
                Console.WriteLine(s);
            }
        }

        static string NomeUpper(Produtos p) 
        {
            return p.Nome.ToUpper();
        }
    }
}