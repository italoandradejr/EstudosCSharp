using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
	class Program
	{
		static void Main(string[] args)
		{
			Recursivo recursivo = new Recursivo();

			recursivo.Executar("Olá mundo", 5);

			Console.ReadKey();
		}
	}
}
