using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_herancaComposicao
{
    public class Sardinha : Animal
    {
        private readonly ComportamentoNadar _comportamentoNadar;

        public Sardinha(ComportamentoNadar comportamentoNadar)
        {
            _comportamentoNadar = comportamentoNadar;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Sardinha));
            _comportamentoNadar.Nadar();
        }
    }
}
