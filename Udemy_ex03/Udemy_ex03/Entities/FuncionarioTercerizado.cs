using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_ex03.Entities
{
    class FuncionarioTercerizado : Funcionarios
    {
        public double DespesaAdicional { get; set; }


        public FuncionarioTercerizado() { }

        public FuncionarioTercerizado(string nome, int horas, double valorPorHora, double despesaAdicional) 
            : base(nome, horas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
