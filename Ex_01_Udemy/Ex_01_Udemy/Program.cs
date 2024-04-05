using Ex_01_Udemy.Entities;
using Ex_01_Udemy.Entities.Enums;
using System;
using System.Globalization;

namespace Ex_01_Udemy
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do Departamento: ");
            string deptNome = Console.ReadLine();

            //Console.WriteLine("Digite a Data: ");
           
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível (Junior/NivelMedio/Senior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());

            Console.Write("Base Salarial: ");
            double baseSalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            Departamento dept = new Departamento(deptNome);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, baseSalarial, dept);


            Console.Write("Quantos contratos para esse trabalhador");
            int n = int.Parse(Console.ReadLine());

            for (int i= 1; i <= n; i++)
            {
                Console.Write($"Digite #{i} - a data do contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Valor por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duração (Horas): ");
                int horas = int.Parse(Console.ReadLine());

                ContratoDeHora contrato = new ContratoDeHora(data, valorPorHora, horas);

                trabalhador.AddContratos(contrato);

            }

            Console.WriteLine();
            Console.WriteLine("Entre com mês e ano para calculo de horas:");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));

            Console.WriteLine("Name: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Renda para: " + mesEAno + ": " + trabalhador.Renda(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}