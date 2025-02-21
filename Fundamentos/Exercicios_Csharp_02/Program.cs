namespace Exercicios_Csharp_02
{
	internal class Program
	{

		//fórmula de Báskara
		static void Main(string[] args)
		{
			Console.WriteLine("digite os valores de a,b e c para calcular a formula de Báskara ");

			Console.Write("a = ");
			int a = Convert.ToInt32(Console.ReadLine());

			Console.Write("b = ");
			int b = Convert.ToInt32(Console.ReadLine());

			Console.Write("c = ");
			int c = Convert.ToInt32(Console.ReadLine());

			double delta = Math.Pow(b, 2) - 4 * a * c;

			double x1Positivo = (-b + Math.Sqrt(delta)) / 2 * a;

			double x2negativo = (-b - Math.Sqrt(delta)) / 2 * a;

			Console.WriteLine($"a = {a}, b = {b}, c = {c}\n");


			if (Double.IsNaN(x1Positivo))
			{
				Console.WriteLine("As raízes são imaginárias");
				Console.WriteLine("Sem solução para os números reais.");
			}
			else
			{
				Console.WriteLine("Ambas as raízes são reais e diferentes");
				Console.WriteLine($"Raiz x1 = {x1Positivo}");
				Console.WriteLine($"Raiz x2 = {x2negativo}");
			}
		}
	}
}
