using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais");

        int idadeJoao = 17;
        int quantidadePessoas = 0;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            if (quantidadePessoas > 0)
            {
                Console.WriteLine("Ele está aconpanhado, pode Entrar!!");
            }
            else
            {
                Console.WriteLine("Não pode Entrar!");
            }

        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}