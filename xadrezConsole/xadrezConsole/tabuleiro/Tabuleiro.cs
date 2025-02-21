using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrezConsole.tabuleiro
{
	class Tabuleiro
	{
		public int linhas { get; set; }
		public int colunas { get; set; }
		private Peca[,] pecas; //matriz, private: não pode ser acessado por um método de fora

		public Tabuleiro(int linhas, int colunas) // construtor
		{
			this.linhas = linhas;
			this.colunas = colunas;
			pecas = new Peca[linhas, colunas]; // refere-se a posição da peça no tabuleiro
		}

		public Peca peca(int linha, int coluna) // esse metodo é criado para  poder acessar o metodo private Peca, na Tela.cs
		{
			return pecas[linha, coluna];
		}

		public Peca peca(Posicao pos)
		{
			return pecas[pos.linha, pos.coluna];
		}

		public bool existePeca(Posicao pos)
		{
			validarPosicao(pos);
			return peca(pos) != null;
		}

		public void colocarPeca(Peca p, Posicao pos)
		{
			if(existePeca(pos))
			{
				throw new TabuleiroException("Já existe uma peça nessa posição");
			}
			pecas[pos.linha, pos.coluna] = p; // acessa a matriz pecas, e atribui a possição  para p;
			p.posicao = pos;

		}

		public bool posicaoaValida(Posicao pos)
		{
			if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
			{
				return false;
			}
			return true;
		}

		public void validarPosicao(Posicao pos)
		{
			if(!posicaoaValida(pos))
			{
				throw new TabuleiroException("Posição inválida!");
			}
		}
	}
}
