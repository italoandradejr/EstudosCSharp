using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/**
			Matematica.Taxa = 10;

			int valor1 = Matematica.Adicionar(200);
			int valor2 = Matematica.Diminuir(200);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

			Console.ReadKey();

			**/

			PessoaAtributos.maioridade = 21;

			PessoaAtributos p1 = new PessoaAtributos();
			p1.nome = "Italo";
			p1.idade = PessoaAtributos.CalcularIdade(1991);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);



			Console.ReadKey();
		}
	}
}
