using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="{0} minimo {2} e maximo {1}")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "{0} obrigatorio")]
        [EmailAddress(ErrorMessage ="Digite um email valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "{0} obrigatorio")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeNasc { get; set; }


        [Required(ErrorMessage = "{0} obrigatorio")]
        [Range(100.0, 50000.0, ErrorMessage ="{0} entre {1} e {2}")]
        [Display(Name = "Salario Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalario { get; set; }

        public Departamento Departamento { get; set; }

        public int DepartamentoId { get; set; }

        public ICollection<RegistroDeVendas> Vendas { get; set; } = new List<RegistroDeVendas>();


        public Vendedor() { } // construtor vazio, é necessario quanto o construtor vai receber argumentos;

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
            return Vendas.Where(sr => sr.Data >= inicial && sr.Data <= final).Sum(sr => sr.Quantia); // soma as venda de um vendedor de um determinado periodo
        }
    }
}
