namespace Exercicios_Csharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

			Console.Write("Digite os valores para n1:  ");
			int n1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Digite os valores para n2:  ");
			int n2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Digite os valores para n3:  ");
			int n3 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"n1: {n1}");
			Console.WriteLine($"n2: {n2}");
			Console.WriteLine($"n3: {n3}");


			if (n1 > n2 && n1 > n3)
			{
				Console.WriteLine($"O maior número é n1: {n1}");
			}
			if(n2 > n1 && n2 > n3)
			{
				Console.WriteLine($"O maior número é n2: {n2}");
			}
			if(n3 > n1 && n3 > n2)
			{
				Console.WriteLine($"O maior número é n3: {n3}");
			}

		}
	}
}
