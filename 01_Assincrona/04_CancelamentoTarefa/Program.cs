using System.Linq.Expressions;

await LancaMultiplasExcecoesAsync();

Console.ReadKey();

static async Task LancaMultiplasExcecoesAsync()
{
    try
    {
        var primeiraTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente");
        });
        var segundaTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente 2");
        });
        await Task.WhenAll(primeiraTask, segundaTask);
    }
    catch(IndexOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch(InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
