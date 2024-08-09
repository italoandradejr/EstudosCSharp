using System;
using UdemyInterface.Entities;

namespace UdemyInterface.Servicos
{
    class ServicoDeAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ITaxaDeServico _ITaxaServico;

        public ServicoDeAluguel(double precoPorHora, double precoPorDia, ITaxaDeServico taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _ITaxaServico = taxaServico;
        }

        public void ProcessoFaturamento (AluguelCarro aluguelDeCarro)
        {
            TimeSpan duracao = aluguelDeCarro.Final.Subtract(aluguelDeCarro.Inicio);

            double pagamentoBasico = 0.0;
            if(duracao.TotalHours <= 12.0) // TotalHours é método da função TimeSpan
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours); // arredonda para cima
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _ITaxaServico.Taxa(pagamentoBasico);

            aluguelDeCarro.Ifatura = new Fatura(pagamentoBasico, imposto);
        }
    }
}
