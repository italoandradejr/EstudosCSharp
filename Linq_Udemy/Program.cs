using System;
using System.Linq;

namespace Linq_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especificar o data Source
            int[] numeros = new int[] { 1, 2, 3, 4, 5, };

            //Definir a expressão da consulta
            var resultado = numeros
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execurar a Consulta

        foreach( int x in resultado )
            {
                Console.WriteLine(x);
            }
        }
    }
}