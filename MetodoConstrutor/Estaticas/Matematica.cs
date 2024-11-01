using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
	static class Matematica
	{
		public static int Taxa;
		public static int Adicionar(int Valor)
		{
			return Valor + Taxa;
		}

		public static int Diminuir(int Valor)
		{
			return Valor - Taxa;
		}
	}
}
