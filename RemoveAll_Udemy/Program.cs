using System;
using RemoveAll_Udemy.Entities;
using System.Collections.Generic;


namespace RemoveAll_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            lista.Add(new Produto("Tv", 900.00));
            lista.Add(new Produto("Mouse", 50.00));
            lista.Add(new Produto("Tablet", 350.50));
            lista.Add(new Produto("HD Case", 80.90));

            lista.RemoveAll(TesteProduto);
            foreach (Produto p in lista)
            {
                Console.WriteLine(p);
            }
        }
        public static bool TesteProduto(Produto p)
        {
            return p.Preco >= 100.0;
        }
    }
}