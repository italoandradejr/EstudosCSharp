using System.Globalization;
using System.Net.Http.Headers;

namespace UdemyInterface.Entities
{
    class AluguelCarro
    {
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public Veiculos Iveiculo { get; set; }
        public Fatura Ifatura { get; set; }

        public AluguelCarro(DateTime inicio, DateTime final, Veiculos iveiculo)
        {
            Inicio = inicio;
            Final = final;
            Iveiculo = iveiculo;
            Ifatura = null;
        }
    }
}
