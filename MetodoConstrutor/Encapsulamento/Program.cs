using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
	 class Program
	{
		static void Main(string[] args)
		{
			Conta c = new Conta();

			c.Cliente = "italo";
			

			// Operação de Deposito
			double valorDeposito = 100;

			c.Depositar(valorDeposito);

			//operação de Saque

			double valorSaque = 50;

			c.Sacar(valorSaque);

            //Resultado Saldo
            Console.WriteLine("Cliente " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);

			Console.ReadKey();
		}
	}
}
