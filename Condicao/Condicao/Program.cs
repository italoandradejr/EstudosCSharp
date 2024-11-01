using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Informe o peso em kg: ");

			double peso = double.Parse(Console.ReadLine());

			Console.Write("Informe a altura em metros: ");

			double altura = double.Parse(Console.ReadLine());

			double valorIMC = peso / (altura * altura);

			if (valorIMC < 20)
			{
				Console.WriteLine("\nA baixo do peso ideal -> Imc = " + valorIMC);
			}
			else if (valorIMC >= 20 && valorIMC <= 24)
			{
				Console.WriteLine("\nPeso normal -> Imc = " + valorIMC);
			}
			else if (valorIMC >= 25 && valorIMC <= 29)
			{
				Console.WriteLine("\nA cima do Peso normal -> Imc = " + valorIMC);
			}
			else if (valorIMC >= 30 && valorIMC <= 34)
			{
				Console.WriteLine("\nObeso -> Imc = " + valorIMC);
			}
			else
			{
				Console.WriteLine("\nMuito Obeso -> Imc = " + valorIMC);
			}

			Console.ReadKey();
		}
	}
}
