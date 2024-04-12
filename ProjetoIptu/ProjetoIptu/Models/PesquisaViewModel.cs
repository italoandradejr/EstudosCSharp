

namespace ProjetoIptu.Models
{
    public class PesquisaViewModel
    {
        public string Proprietario { get; set; }
        public string Grupo { get; set; }
        public string Empreendimento { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string ContribuinteImovel { get; set; }
    }
}
