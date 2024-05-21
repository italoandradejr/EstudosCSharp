using System;
using System.Globalization;
using Udemy_ex03.Entities;

namespace Udemy_ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> list = new List<Funcionarios>();

            Console.Write("Entre com a quantidade de Funcionarios: ");
            int n = int.Parse(Console.ReadLine());


            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados de Funcionario N°{i}: ");

                Console.Write("É Tercerizado?(y/n): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y')
                {
                    Console.Write("Cobrança Adicional: ");
                    double cobrancaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new FuncionarioTercerizado(nome, horas, valorPorHora, cobrancaAdicional));
                }
                else
                {
                    list.Add(new Funcionarios(nome, horas, valorPorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS: ");

            foreach (Funcionarios emp in list)
            {
                Console.WriteLine(emp.Nome + " - $ " + emp.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}