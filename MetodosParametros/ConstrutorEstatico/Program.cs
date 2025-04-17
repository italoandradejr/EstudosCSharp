Console.WriteLine("##Construtor Estático##\n");

// invoca o construtor parametrizado e o estatico

Pessoa p3 = new Pessoa();

Pessoa p1 = new(19, "Maria");
Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

//invoca somente o construtor parametrizado
Pessoa p2 = new(58, "Alves");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);


p3 = new (33, "ITALO");
Console.WriteLine(p3.Nome + " - " + p3.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);


Console.ReadKey();

public class Pessoa
{
    public static int IdadeMinima;
    public int Idade { get; set; }
    public string Nome { get; set; }

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Idade = idade;
        Nome = nome;
    }

    public Pessoa() { }

    // ao instanciar o objeto p1, o constritor estático da classe pessoa é executado automaticamente e apenas uma vez, antes da primeira instância da classe ser criada
    // para o objeto p2, o construtor estático já foi executado, ele não será  chamado novamente.
    static Pessoa() 
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("\nInicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}