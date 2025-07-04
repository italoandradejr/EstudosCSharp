using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Ex
{
    public abstract class ArquivoBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("Definir o nome do arquivo");
        }
    }
}
