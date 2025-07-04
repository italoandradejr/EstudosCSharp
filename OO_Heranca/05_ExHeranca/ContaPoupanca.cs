using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ExHeranca
{
    public class ContaPoupanca : Conta
    {
        public override double Juros { get; set; } = 0.005;
        public override decimal Sacar(decimal valor) // override prioriza esse método
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente...");
                return Saldo;
            }
        }
    }
}
