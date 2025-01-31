using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrezConsole.tabuleiro
{
	class Peca
	{
		public Posicao posicao { get; set; } // encapsulamento, esse atributo pode ser acessado e alterado por outras classes
		public Cor cor { get; protected set; } // get pode ser acessada e alterada,  set so pode ser alterada por ela mesma ou por uma subclasse
		public int qteMovimentos { get; protected set; }
		public Tabuleiro tab { get; protected set; }

		public Peca(Tabuleiro tab, Cor cor) // construtor dos elementos acima
		{
			this.posicao = null; //this instancia um objeto
			this.tab = tab;
			this.cor = cor;
			this.qteMovimentos = 0;
			
		}
	}
}
