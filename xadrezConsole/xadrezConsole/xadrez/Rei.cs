using xadrezConsole.tabuleiro;

namespace xadrezConsole.xadrez
{
	class Rei : Peca
	{
		public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) // repassa os parametros para a classe generica Peca.cs
		{
		}
		public override string ToString()
		{
			return "R";
		}
	}
}
