Console.WriteLine("## Métodos ##");

Cadastro cadastro = new Cadastro();
var clienteNovo = cadastro.Registrar(); // cria um objeto sem paramêtro
cadastro.ExibirDados(clienteNovo);

clienteNovo = cadastro.Registrar(clienteNovo); // cria um objeto com paramêtro
cadastro.ExibirDados("Renda Alterada", clienteNovo);


Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente()
    {

    }
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new("Maria", 23, 3000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados (Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome}, {cliente.Idade} , {cliente.Renda.ToString("c")}");
    }

    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.Write($"\n{texto}\t");
        Console.WriteLine($"{cliente.Nome}, {cliente.Idade} , {cliente.Renda.ToString("c")}");
    }
}