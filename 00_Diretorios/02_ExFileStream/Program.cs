

string caminhoArquivo = @"C:\\Users\\italo.silva\\Documents\\CSharp\\EstudosCSharp\\00_Diretorios\\txt\arquivo1.txt";

//FileStream fs = null;
//StreamReader leitor = null;

//try
//{
//    fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
//    leitor = new StreamReader(fs);

//    String? linha;
//    while ((linha = leitor.ReadLine()) != null)
//    {
//        Console.WriteLine(linha);
//    }
//}
//catch (IOException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    if (leitor != null)
//    {
//        leitor.Close();
//    }
//    if (fs != null)
//    {
//        fs.Close();
//    }
//}


// usando o bloco using

try
{
    using(FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read))
    {
        using(StreamReader leitor = new StreamReader(fs))
        {
            string? linha;
            while ((linha = leitor.ReadLine()) != null) 
            {
                Console.WriteLine(linha);
            }
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);   
}

Console.ReadKey();
