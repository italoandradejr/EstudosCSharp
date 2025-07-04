

Cliente cli = new();
cli.Nome = "José";
cli.ExibeNome();

Console.ReadKey();

sealed class Pessoa
{
    public string? Nome { get; set; }
    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente
{
    public void ExibeNome()
    {
        Console.WriteLine($"\nNome do cliente: {Nome}");
    }
}