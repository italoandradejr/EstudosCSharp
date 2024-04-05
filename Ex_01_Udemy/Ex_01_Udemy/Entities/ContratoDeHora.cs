using System;

namespace Ex_01_Udemy.Entities
{
     class ContratoDeHora
     {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoDeHora() 
        {
            
        }

        public ContratoDeHora(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal ()
        {
            return  Horas * ValorPorHora;
        }
     }
}
