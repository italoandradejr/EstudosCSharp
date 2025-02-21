namespace Fundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Cliente especial (S/N): ");
            var resposta = Console.ReadLine();

            if(resposta == "S")
            {
				Console.WriteLine("Desconto de 10%");
            }

            Console.ReadKey();
        }
    }
}
