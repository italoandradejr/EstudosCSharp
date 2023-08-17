using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;

try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
    /*
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());
    */
}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
    Console.WriteLine("Não é possivel criar uma conta");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada, saldo insuficiente!");
    Console.WriteLine(ex.Message);
}