using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_ex03.Entities
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public int Horas { get; set;}

        public double ValorPorHora { get; set; }

        public Funcionarios() { }

        public Funcionarios(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }


        public virtual double Pagamento ()
        {
            return Horas * ValorPorHora;
        }
    }
}
