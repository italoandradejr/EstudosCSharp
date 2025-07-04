using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ExHeranca
{
    public class Conta
    {
        public int Numero {  get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; } = 0.00m;
        public virtual double Juros { get; set; } = 0.00; // pode ser alterado/sobreposto (virtual)

        private decimal CalculaRemuneracao(double juros)
        {
            return Saldo * (decimal)Juros;
        }

        public virtual decimal Sacar(decimal valor) // virtual permite sobrescrever o método
        {
            Saldo = Saldo - valor;
            return Saldo;
        }

        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            Saldo = Saldo + CalculaRemuneracao(Juros);
            return Saldo;
        }


    }
}
