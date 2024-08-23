using ExUdemyLing.Entities;
using System;
using System.Globalization;
using System.Linq;

namespace ExUdemyLing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho do arquivo: ");
            string caminho = Console.ReadLine();

            List<Produto> lista = new List<Produto>();

            using (StreamReader sr = File.OpenText(caminho))
            {
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(',');
                    string nome0 = campos[0];
                    double preco1 = double.Parse(campos[1], CultureInfo.InvariantCulture);
                    lista.Add(new Produto(nome0, preco1));
                }
            }

            var avg = lista.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Média de Preços = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var nomes = lista.Where(p => p.Preco < avg).OrderByDescending(p => p.Nome).Select(p => p.Nome);
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}