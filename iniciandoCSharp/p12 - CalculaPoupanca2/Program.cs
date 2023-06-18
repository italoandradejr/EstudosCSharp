using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Calcula Poupança 2");

        /*
        while (mes <= 12)
        {
            investimento = investimento + (investimento * 0.005);
            Console.WriteLine("No Mês: " + mes + " Você tem: " + investimento);
            mes++;
        }
        */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No Mês: " + mes + " Você tem: " + investimento);
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}


