using System.Globalization;

namespace UdemyInterface.Entities
{
    class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public Fatura(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        public double TotalPagamento
        {
            get { return PagamentoBasico + Imposto; }
        }

        public override string ToString()
        {
            return "Pagamento Basico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Imposto.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: "
                + TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
