
using _04_ElementosI;

Console.WriteLine("\nAlunos matriculados e seus endeçoes \n");


var consulta = from aluno in FonteDados.GetAlunos()
               join endereco in FonteDados.GetEnderecos()
               on aluno.EnderecoId equals endereco.Id
               join curso in FonteDados.GetCursos()
               on aluno.CursoId equals curso.Id
               select new
               {
                   ID = aluno.Id,
                   AlunoNome = aluno.Nome,
                   CursoNome = curso.Nome,
                   EnderecoLocal = endereco.Local,
               };


foreach (var item in consulta)
{
    Console.WriteLine($"ID = {item.ID}\t Nome = {item.AlunoNome} " + $"\tEndereço = {item.EnderecoLocal}\t Curso = {item.CursoNome}");
}

Console.ReadKey();