Console.WriteLine("## Métodos - Parâmetros ##\n");

Aluno aluno = new Aluno();

Console.WriteLine("Nome: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Idade: ");
aluno.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sexo: ");
aluno.Sexo = Console.ReadLine();

Console.WriteLine("aprovado S/N: ");
aluno.Aprovado = Console.ReadLine();


Curso curso = new Curso();
curso.Resuldado(aluno.Nome, aluno.Idade, aluno.Sexo, aluno.Aprovado);

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

public class Curso
{
    public void Resuldado(string nome, int idade, string sexo, string aprovado)
    {
        Console.WriteLine($"\nO Aluno {nome}, sexo {sexo} com { idade} anos");
        if(aprovado == "S")
        {
            Console.WriteLine("\n Foi aprovado");
        }
        else
        {
            Console.WriteLine("\n Foi reprovado");
        }
            
    }
}