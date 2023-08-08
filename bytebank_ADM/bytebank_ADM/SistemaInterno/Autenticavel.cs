using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public interface Autenticavel 
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha);
                    
    }
}
