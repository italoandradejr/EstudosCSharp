using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrezConsole.tabuleiro
{
	class Posicao
	{
		public int linha {  get; set; } // encapsulamento, esse atributo pode ser acessado e alterado por outras classes
		public int coluna { get; set; } // encapsulamento, esse atributo pode ser acessado e alterado por outras classes

		public Posicao(int  linha, int coluna) // construtor 
		{
			this.linha = linha; //this instancia um objeto
			this.coluna = coluna; //this instancia um objeto
		}

		public override string ToString()  // metodo de sobreposição
		{
			return linha
				+ ", "
				+ coluna;
		}
	}
}
