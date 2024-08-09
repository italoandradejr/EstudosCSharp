using Equals_Udemy.Entities;
using System;
using System.Globalization;

namespace Equals_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente a = new Cliente { Nome = "Maria", Email = "maria@gmail.com" };
            Cliente b = new Cliente { Nome = "Italo", Email = "italo@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}