﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
	 class Program
	{
		static void Main(string[] args)
		{
			Teste t = new Teste();

			t.Nome = "Italo";
			t.Idade = 33;

            Console.WriteLine(t.Nome + " " + t.Sobrenome);
            Console.WriteLine(t.Idade);

			Console.ReadKey();
		}
	}
}
