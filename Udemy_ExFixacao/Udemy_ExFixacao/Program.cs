using System.Globalization;
using Udemy_ExFixacao.Entities.Enums;
using Udemy_ExFixacao.Entities;

namespace Udemy_ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados Cliente: ");
            Console.Write("Nome: ");
            string clienteNome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/YYYY): ");
            DateTime DataNasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data da Ordem: ");
            Console.Write("Status: ");
            OrdemStatus status = Enum.Parse<OrdemStatus>(Console.ReadLine());

            Cliente cliente = new Cliente(clienteNome, email, DataNasc);
            Ordem ordem = new Ordem(DateTime.Now, status, cliente);

            Console.Write("Quantos itens para este pedido?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite #{i} Data do item:");
                Console.Write("Nome Do Produto: ");
                string NomeDoProduto = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(NomeDoProduto, preco);
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                OrdemItem ordemItem = new OrdemItem(quantidade, preco, produto);

                ordem.AddItem(ordemItem);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de Ordens:");
            Console.WriteLine(ordem);
        }
    }
}