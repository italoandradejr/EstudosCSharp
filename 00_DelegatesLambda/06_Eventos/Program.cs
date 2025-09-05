
Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();

//inscrever os assinantes no evento
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();

Console.ReadKey();

//criar o delegate para evento
delegate void PedidoEventoHandler();

class Pedido
{
    public event PedidoEventoHandler? OnCriarPedido;
    public void CriarPedido()
    {
        Console.WriteLine("\nPedido Criado!!!");
        if(OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

class Email
{
    public static void Enviar()
    {
        Console.WriteLine("\nEnviando um email...");
    }
}

class SMS
{
    public static void Enviar()
    {
        Console.WriteLine("\nEnviando um SMS...");
    }
}