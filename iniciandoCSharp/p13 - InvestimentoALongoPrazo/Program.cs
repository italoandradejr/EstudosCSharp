using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Investimento a longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
                Console.WriteLine("No mês: " + mes + " do ano: " + anos + " O Valor investido é: " + investimento);
            }

            fatorRendimento +=0.001;
        }

        Console.WriteLine("Depois de 5 anos você terá R$: " + investimento);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}


