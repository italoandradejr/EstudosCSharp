using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PagamentoPendentes
            };

            Console.WriteLine(order + " => sainda variável Order");

            string txt = OrderStatus.PagamentoPendentes.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Entregue");

            Console.WriteLine(os + " => sainda variável os");
            Console.WriteLine(txt + " => sainda variável txt");
        }
    }
}