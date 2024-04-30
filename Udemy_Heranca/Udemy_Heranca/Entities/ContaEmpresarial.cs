using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Udemy_Heranca.Entities
{
    class ContaEmpresarial : Conta
    {
        public double LimiteParaEmprestimo { get; set; }

        public ContaEmpresarial()
        {
        }

        public ContaEmpresarial (int numero, string titular, double saldo, double limiteparaemprestimo) 
            : base(numero,titular,saldo)
        {
            LimiteParaEmprestimo = limiteparaemprestimo;
        }

        public void Emprestimo (double quantia)
        {
            if (quantia <= LimiteParaEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}
