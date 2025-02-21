namespace Csharp_Switch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("informe o nome do mês\t");

			var mes = Console.ReadLine().ToLower();

			switch (mes)
			{
				case "fevereiro":
					Console.WriteLine("Esse mês tem 28 ou 29 dias");
					break;
				case "dezembro":
					Console.WriteLine("esse mês tem 31 dias");
					break;

				default:
					Console.WriteLine("esse mes tem 30 dias");
					break;

			}

			Console.ReadKey();
		}
	}
}
