using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class RegistroDeVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantia { get; set; }
        public StatusDeVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroDeVendas() { } // construtor vazio, é necessario quanto o construtor vai receber argumentos;

		public RegistroDeVendas(int id, DateTime data, double quantia, StatusDeVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
