using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Ex
{
    public class SalvarJson : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvar arquivo json");
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome Json");
        }
    }
}
