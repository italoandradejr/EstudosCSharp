Console.WriteLine("## Assainatura de método - Sobrecarga ##\n");

Email email = new Email();
email.Enviar("empressa.com.br");
email.Enviar("empressa.com.br", "proposta comercial para analise");
email.Enviar("empressa.com.br", 200);
email.Enviar(100, "empressa.com.br");


Console.ReadKey();


public class Email
{
    public void Enviar (string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto Padrão");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta comercial");
        Console.WriteLine($"{valor}");
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento Fornecedor");
        Console.WriteLine($"{valor}");
    }
}