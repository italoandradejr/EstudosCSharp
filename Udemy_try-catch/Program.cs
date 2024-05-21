using System;

namespace Udemy_tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 / n2;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException e)
            {
                // exibe erro quando dividido por 0
                Console.WriteLine("Erro! " + e.Message);
                Console.WriteLine("--------------------");
                Console.WriteLine("Não é permitido divisão por 0");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro de formato " + e);
            }
        }
    }
}