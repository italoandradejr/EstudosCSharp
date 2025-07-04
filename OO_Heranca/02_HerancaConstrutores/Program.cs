
Aluno aluno = new Aluno("José");


Console.ReadKey();

//base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("construtor da classe pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor classe pessao com parametro");
    }
}

//derivada
class Aluno : Pessoa
{
    public Aluno()
    {
        Console.WriteLine("construtor da classe Aluno");
    }
    public Aluno(string nome)
    {
        Console.WriteLine("Construtor classe aluno com parametro");
    }
}