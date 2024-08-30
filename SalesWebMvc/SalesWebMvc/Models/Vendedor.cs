using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNasc { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroDeVendas> Vendas { get; set; } = new List<RegistroDeVendas>();


        public Vendedor() { }

        public Vendedor(int id, string nome, string email, DateTime dataDeNasc, double baseSalario, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataDeNasc = dataDeNasc;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AddVendas(RegistroDeVendas sr)
        {
            Vendas.Add(sr);
        }

        public void RemoverVenda (RegistroDeVendas sr)
        {
            Vendas.Remove(sr);
        }

        public double TotalVendas (DateTime inicial, DateTime final)
        {
            return Vendas.Where(sr => sr.Data >= inicial && sr.Data <= final).Sum(sr => sr.Quantia);
        }
    }
}
