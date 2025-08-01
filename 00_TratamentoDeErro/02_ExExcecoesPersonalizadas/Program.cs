
using _02_ExExcecoesPersonalizadas;

Conta conta1 = new Conta(100, "Maria", 100m);

try
{
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(100);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
    conta1.Sacar(300);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}




Console.ReadKey();

public class Conta
{
    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }

    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depositou: {valor}");
        return Saldo;
    }

    public decimal Sacar(decimal valor)
    {
        Console.WriteLine($"Sacou: { valor}");
        if (Saldo < valor)
            throw new SaldoInsuficienteException(valor,Saldo);

        Saldo -= valor;
        return Saldo;
    }

    public override string ToString()
    {
        return $"Conta: {Numero} : {Titular} - Saldo = {Saldo}";
    }

}