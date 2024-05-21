using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuliero(Tabuleiro tabTela)
        {
            for (int i = 0; i < tabTela.linhas; i++)
            {
                for (int j = 0; j < tabTela.colunas; j++)
                {
                    if (tabTela.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabTela.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
