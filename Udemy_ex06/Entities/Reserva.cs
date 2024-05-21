using System;
using Udemy_ex06.Entities.Exceptions;

namespace Udemy_ex06.Entities
{
     class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva() { }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DominioExcecoes("Erro na reserva: data de check-out tem que ser depois da data de check-in");
            } 

            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void UpdateDatas(DateTime checkIn, DateTime checkOut) 
        {
            DateTime agora = DateTime.Now;
            if (checkIn < agora || checkOut < agora)
            {
                throw new DominioExcecoes("Erro na reserva, as datas da reserva para atualização tem que ser datas futuras");
            }
            if (checkOut <= checkIn)
            {
                throw new DominioExcecoes("Erro na reserva: data de check-out tem que ser depois da data de check-in");
            }
            
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Quarto"
                + NumeroQuarto
                + ", Check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duracao()
                + "Noites";
        }
    }
}
