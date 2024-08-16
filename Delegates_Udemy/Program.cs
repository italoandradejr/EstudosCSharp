using Delegates_Udemy.Services;
using System.Net.WebSockets;

namespace Delegates_Udemy
{

    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            double resultado = CalculationService.Sum(a, b);

            Console.WriteLine(resultado);
        }
    }
}