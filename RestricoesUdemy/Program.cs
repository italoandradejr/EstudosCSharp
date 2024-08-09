using RestricoesUdemy.Entities;
using RestricoesUdemy.Services;
using System.Globalization;

namespace RestricoesUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listaN = new List<Product>();

            Console.Write("Entre com o N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string nomeA = vect[0];
                double precoA = double.Parse(vect[1], CultureInfo.InvariantCulture);
                listaN.Add(new Product(nomeA, precoA));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Maximo(listaN);

            Console.Write("Max: ");
            Console.WriteLine(max);
        }
    }
}