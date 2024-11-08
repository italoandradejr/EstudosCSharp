using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
	// não recursivo
	class Recursivo
	{
		public void Executar(string mensagem, int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(mensagem + " N: " + i);
			}
		}


		// recursivo
		public void ExecutarRecursivo(string mensagem, int n)
		{
			if (n > 0)
			{
				Console.WriteLine(mensagem);
				ExecutarRecursivo(mensagem, n - 1);
			}
		}
	}
}
