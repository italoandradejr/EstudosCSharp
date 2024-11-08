using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialN
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Digite um número para calcular o fatorial:");
			int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial de: "+ numero + " é " + Fatorial(numero));

			Console.ReadKey();
		}

		static int Fatorial(int num)
		{
			if (num <= 0)
			{
				return 1;
			}
			return num * Fatorial(num - 1);

		}

	}
}
