Console.WriteLine("## Construtores ##");


Aluno aluno = new Aluno("Italo", 33, "M", "S");

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Idade);
Console.WriteLine(aluno.Sexo);
Console.WriteLine(aluno.Aprovado);

Console.ReadKey();


public class Aluno
{
    public Aluno(string nome)
    {
        Nome = nome;
    }

    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}