using ByteBankIO;
using System.Text;


partial class Program
{
    static void Main(string[] args)
    {
        UsarStreamDeEntrada();

        Console.WriteLine("Aplicação finalizada..");

        Console.ReadLine();
    }
}


/*
var caminhoNovoArquivo = "TestaEscrita.txt";

using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
using (var escritor = new StreamWriter(fluxoDeArquivo))
{
    escritor.WriteLine(true);
    escritor.WriteLine(false);
    escritor.WriteLine(545454545454);
}

Console.WriteLine("Aplicação finalizada...");
*/

//Console.WriteLine("Digite seu nome:");
//var nome = Console.ReadLine();

//var linhas = File.ReadAllLines("contas.txt");
//Console.WriteLine(linhas.Length);

/*
foreach (var linha in linhas)
{
    Console.WriteLine(linha);
}
*/

//var bytesArquivo = File.ReadAllBytes("contas.txt");
//Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

//File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

//Console.WriteLine("Aplicação Finalizada ...");

//Console.ReadLine();