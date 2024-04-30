using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Heranca.Entities
{
    sealed class ContaPoupanca : Conta
    {
        public double TaxaDeJuros {  get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca (int numero, string titular, double saldo, double taxadejuros) 
            : base(numero, titular, saldo)
        {
            TaxaDeJuros = taxadejuros;
        }

        public void AtualizaSaldo()
        {
            Saldo += Saldo * TaxaDeJuros;
        }

        public override void Saque(double quantia)
        {
            base.Saque(quantia);
            Saldo -= 2.0;
        }
    }
}
