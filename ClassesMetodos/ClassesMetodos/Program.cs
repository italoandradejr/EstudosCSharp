Console.WriteLine("## Classes e Métodos ##\n");

Pessoa p1 = new Pessoa();
p1.nome = "Italo";
p1.idade = 33;
p1.sexo = "Masculino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");


Pessoa p2 = new Pessoa();
p2.nome = "Rachel";
p2.idade = 40;
p2.sexo = "Feminino";

Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");

Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}