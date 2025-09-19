

Console.WriteLine("###\n Iniciando a operação Assíncrono... ###");
await MetodoSemRetornoAsync();

Console.WriteLine("###\n Iniciando a operação Assíncrono... ###");
var resultado = await MetodoRetornoValorAsync(20);
Console.WriteLine($"Resultado: {resultado}");

Console.ReadKey();  

static async ValueTask MetodoSemRetornoAsync()
{
    Console.WriteLine("-Método que não retorna valor");
    await Task.Delay(2000);
}

static async ValueTask<int> MetodoRetornoValorAsync(int valor)
{
    Console.WriteLine("-Método que retorna valor");
    await Task.Delay(2000);
    return valor * 2;
}