using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ExHeranca
{
    public class ContaInvestimento : Conta
    {
        public override double Juros { get; set; } = 0.009; // override sobrepos o metodo da Conta.cs
        public double Imposto { get; set; } = 0.001;

        private decimal CalculaImposto(double imposto)
        {
            return Saldo * (decimal)Imposto;
        }

        public override decimal Sacar(decimal valor) // override prioriza esse método
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor - CalculaImposto(Imposto);
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
