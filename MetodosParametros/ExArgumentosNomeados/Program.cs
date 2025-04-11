Console.WriteLine("## EX Argumentos Nomeados##");

Informacao info = new Informacao();

info.ExibirInfo("focus", "GM", "GM+", 10, 2010);


Console.ReadKey();


public class Informacao
{
    public void ExibirInfo(string Modelo, string Montadora, string Marca, int Potencia, int Ano= 2010)
    {
        Console.WriteLine($"\n Carro modelo: {Modelo}, Mondadora: {Montadora}, Marca: {Marca}, Potencia: {Potencia}hp, Ano: {Ano}");
    }
}