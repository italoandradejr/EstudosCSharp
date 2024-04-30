
using System.Globalization;
using System.Text;
using Udemy_ExFixacao.Entities.Enums;

namespace Udemy_ExFixacao.Entities
{
    class Ordem
    {
        public DateTime Momento { get; set; }
        public OrdemStatus Status {  get; set; }
        public Cliente Clientes { get; set; }
        public List<OrdemItem> Itens { get; set; } = new List<OrdemItem>();



        public Ordem() { }

        public Ordem(DateTime momento, OrdemStatus status, Cliente clientes)
        {
            Momento = momento;
            Status = status;
            Clientes = clientes;
        }


        public void AddItem(OrdemItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrdemItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach (OrdemItem item in Itens)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Data da Ordem: " + Momento.ToString("dd/MM/yyyy"));
            sb.AppendLine("Ordem Status: " + Status);
            sb.AppendLine("Cliente: " + Clientes);
            sb.AppendLine("Ordem Item: ");

            foreach (OrdemItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
