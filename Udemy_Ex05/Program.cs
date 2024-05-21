using System.Globalization;
using Udemy_Ex05.Entities;
using Udemy_Ex05.Entities.Enums;

namespace Udemy_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>();

            Console.Write("Entre Com a quantidade de Figuras: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura #{i} dado: ");
               
                Console.Write("Retangulo ou Circulo (r/c)?: ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Qual é a cor (black/Blue/Red)?: ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }
                           
            }
            Console.WriteLine();
            Console.WriteLine("Areas das Figuras");

            foreach (Figura figura in list)
            {
                Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}