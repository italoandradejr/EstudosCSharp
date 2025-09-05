
var caminhoDiretorio = @"C:\Users\italo.silva\Documents\CSharp\EstudosCSharp\00_Diretorios\MeuDiretorio";

Console.WriteLine("\nCriando um novo Diretório: ");


try
{
    if(!Directory.Exists(caminhoDiretorio))
    {
        Directory.CreateDirectory(caminhoDiretorio);
        Console.WriteLine($"\nDiretório {caminhoDiretorio} criado com sucesso!");
    }
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio} já existe");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();