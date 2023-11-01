using ByteBankIO;
using System.Text;


partial class Program
{
    static void Main(string[] args)
    {
        EscritaBinaria();
        LeituraBinaria();

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