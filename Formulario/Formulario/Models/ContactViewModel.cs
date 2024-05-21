using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Formulario.Models
{
	public class ContactViewModel
	{
		[DisplayName("Nome(*)")]
		[Required(ErrorMessage = "Campo Nome Obrigatório")]
		[MinLength(3, ErrorMessage ="Nome deve ter no mínimo 3 caracteres")]
        public string Nome { get; set; }


        public string Cargo { get; set; }
		public string Empresa { get; set; }
		public string Fone { get; set; }



		[Required(ErrorMessage = "Campo Email Obrigatório")]
		[EmailAddress(ErrorMessage ="Email Inválido")]

		
		[DisplayName("Email(*)")]
		public string Email { get; set; }


		public string Assunto { get; set; }



		[DisplayName("Digite sua Mensagem(*)")]
		[Required(ErrorMessage = "Campo Mensagem Obrigatório")]
		[MinLength(10, ErrorMessage = "Nome deve ter no mínimo 10 caracteres")]
		public string Mensagem { get; set; }
	}
}
