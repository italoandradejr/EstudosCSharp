namespace While_Csharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numero;
			int contador = 1;

			Console.Write("Digite um número > que 0: ");
			numero = Convert.ToInt32(Console.ReadLine());

			if (numero > 0)
			{
				// loop

				Console.WriteLine($"\nTabuada do {numero}");

				while(contador < 11)
				{
					Console.WriteLine($"{numero} x {contador} = {numero * contador}");
					contador++;
				}
			}
			else
			{
				Console.WriteLine("\nNúmero deve ser maior que zero!!");
			}

			Console.WriteLine("\n Fim do processamento...");
			Console.ReadKey();
		}
	}
}
