using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _02_ExExcecoesPersonalizadas
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string? message) : base(message)
        {
        }

        public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public SaldoInsuficienteException(decimal saque, decimal saldo) : base($"\nException: valor do saque {saque} é superior ao saldo {saldo}")
        {

        }
    }
}
