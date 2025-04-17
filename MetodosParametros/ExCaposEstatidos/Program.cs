Console.WriteLine("##Exercício - Campos Estáticos ##\n");

Console.WriteLine($"Camando o método estático ObterValorIpva: {IPVA.ValorIpva} antes de executar o método");

IPVA.ObterValorIpva();

Console.WriteLine($"Camando o método estático ObterValorIpva: {IPVA.ValorIpva}");

Console.ReadKey();



public class IPVA
{
    public static int ValorIpva = 43;

    public static void ObterValorIpva()
    {
         ValorIpva = 4;
    }
}