using System;
using System.Globalization;
using UdemyInterface.Entities;
using UdemyInterface.Servicos;

namespace UdemyInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel: ");

            Console.Write("Modelo do Carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Data de Inicio (dd/MM/yyyy hh:mm): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Data de Fim (dd/MM/yyyy hh:mm): ");
            DateTime final = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Digite o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o preço por Dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            AluguelCarro carroDeAluguel = new AluguelCarro(inicio, final, new Veiculos(modelo));
            ServicoDeAluguel servicoDeAluguel = new ServicoDeAluguel(hora, dia, new TaxaDeServicoBrazil());

            servicoDeAluguel.ProcessoFaturamento(carroDeAluguel);

            Console.WriteLine("Fatura: ");
            Console.WriteLine(carroDeAluguel.Ifatura);
        }
    }
}