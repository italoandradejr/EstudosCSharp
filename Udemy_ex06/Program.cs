using System;
using Udemy_ex06.Entities;
using Udemy_ex06.Entities.Exceptions;


public class ArquivoProcesso
{
    public static void Main()
    {
        try
        {
            Console.Write("Número do Quato: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Data do Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Data do Check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            Reserva reserva = new Reserva(numero, checkIn, checkOut);
            Console.WriteLine("Reserva");

            Console.WriteLine();
            Console.WriteLine("Entre com os dados para atualizar a Reserva: ");

            Console.Write("Data do Check-in (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Data do Check-out (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reserva.UpdateDatas(checkIn, checkOut);
            Console.WriteLine("Reserva: " + reserva);
        }
        catch (DominioExcecoes e)
        {
            Console.WriteLine("Erro na reserva: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Erro no formado de dado: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro inesperado: " + e.Message);
        }
    }
}