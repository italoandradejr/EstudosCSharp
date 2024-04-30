using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_ex_2.Entities
{
     class Comentario
     {
        public string Texto { get; set; }   

        public Comentario() 
        {

        }

        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}
