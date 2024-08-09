
using System.Globalization;

namespace RestricoesUdemy.Entities
{
    class Product : IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparativo errado: Argumento não é um produto");
            }
            Product outro = obj as Product;
            return Preco.CompareTo(outro.Preco);
        }
    }
}
