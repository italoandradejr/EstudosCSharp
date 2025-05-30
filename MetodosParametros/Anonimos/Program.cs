Console.WriteLine("##Anonimos###");


//var aluno = new
//{
//    Nome = "Maria",
//    Idade = 43
//};


var aluno = new
{
    Id = 1,
    Nome = "Jairo",
    Email = "Jairo@email.com",
    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }
};

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Endereco.Cidade);

Console.WriteLine(aluno.GetType().ToString());
//Console.WriteLine(aluno.Nome + " " + aluno.Idade);


Console.ReadKey();