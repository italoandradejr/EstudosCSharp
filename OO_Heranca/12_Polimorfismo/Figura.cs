using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polimorfismo
{
    public class Figura
    {
        public virtual void Desenhar()
        {
            Console.WriteLine("Executando desenhar na classe base");
        }
    }
}
