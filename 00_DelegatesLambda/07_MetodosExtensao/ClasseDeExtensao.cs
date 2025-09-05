using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MetodosExtensao
{
    public static class ClasseDeExtensao
    {
        public static string InverteString(this string Textostr)
        {
            char[] charDeArray = Textostr.ToCharArray();
            Array.Reverse(charDeArray);
            return new string(charDeArray);
        }
    }
}
