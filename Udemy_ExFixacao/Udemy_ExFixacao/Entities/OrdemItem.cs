
using System.Diagnostics;
using System.Globalization;

namespace Udemy_ExFixacao.Entities
{
    class OrdemItem
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produtos { get; set;}



        public OrdemItem()
        {
        }

        public OrdemItem(int quantidade, double preco, Produto produtos)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produtos = produtos;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Produtos.Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }   
}
