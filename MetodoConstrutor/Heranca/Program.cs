using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Carro carro = new Carro();
			Bicicleta bicicleta = new Bicicleta();

			carro.Acelerar();
			bicicleta.Acelerar();

			carro.Parar();
			bicicleta.Parar();

			Console.ReadKey();

            Console.WriteLine("------------------------------------------------------------------");

			Humano a = new Humano();
			Pessoa b = new Pessoa();
			Homem c = new Homem();

            Console.WriteLine("Humano");
			a.Olhos();
			a.Cabelos();

            Console.WriteLine("Pessoa");
			b.Olhos();
			b.Cabelos();

            Console.WriteLine("Homem");
			c.Olhos();
			c.Cabelos();

			Console.ReadKey();
		}
	}
}
